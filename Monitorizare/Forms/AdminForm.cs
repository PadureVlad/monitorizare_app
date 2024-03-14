using Microsoft.Data.Sqlite;
using Monitorizare.AdminForms;
using Monitorizare.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Monitorizare.Forms
{
    public partial class AdminForm : Form
    {
        private const string ConnectionString = "Data Source = Monitorizare.db"; //Initializam conectiunea cu baza de date
        private readonly List<Vehicule> _vehicule;
        public AdminForm()
        {
            InitializeComponent();
            _vehicule = new List<Vehicule>();
        }
        private void DisplayVehicule()
        {
            lvVehicule.Items.Clear();
            foreach (Vehicule vehicul in _vehicule)
            {
                var listViewItem = new ListViewItem(vehicul.Id.ToString());
                listViewItem.SubItems.Add(vehicul.TipVehicul);
                listViewItem.SubItems.Add(vehicul.NrRutei);
                listViewItem.SubItems.Add(vehicul.Locatia);
                listViewItem.SubItems.Add(vehicul.Disponibil);
                listViewItem.SubItems.Add(vehicul.Utilizat);
                listViewItem.SubItems.Add(vehicul.Functionare);
                listViewItem.SubItems.Add(vehicul.TimpulSosire);
                listViewItem.SubItems.Add(vehicul.ProblemeTehnice);
                listViewItem.SubItems.Add(vehicul.NivelCombustibil.ToString("0.0 l"));
                listViewItem.SubItems.Add(vehicul.PunctInteres);
                listViewItem.SubItems.Add(vehicul.NrCalatori.ToString());
                listViewItem.SubItems.Add(vehicul.ZonaRisc);
                listViewItem.SubItems.Add(vehicul.Viteza.ToString("0.0 km/h"));
                listViewItem.Tag = vehicul;
                lvVehicule.Items.Add(listViewItem);
            }
        }
        private void LoadVehicule()
        {
            _vehicule.Clear();
            const string stringSql = "SELECT * FROM Vehicul";
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqliteCommand(stringSql, connection);
                using (SqliteDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        long id = (long)sqlReader["Id"];
                        string tipVehicul = (string)sqlReader["TipulVehiculului"];
                        string nrRutei = (string)sqlReader["NrRutei"];
                        string locatia = (string)sqlReader["Locatia"];
                        string disponibil = (string)sqlReader["Disponibil"];
                        string utilizat = (string)sqlReader["Utilizat"];
                        string functionare = (string)sqlReader["Functionare"];
                        string timpSosire = (string)sqlReader["TimpulSosire"];
                        string problemeTehnice = (string)sqlReader["ProblemeTehnice"];
                        double nivelCombustibil = (double)sqlReader["NivelCombustibil"];
                        string punctInteres = (string)sqlReader["PunctInteres"];
                        int nrCalatori = Convert.ToInt32(sqlReader["NrCalatori"]);
                        string zonaRisc = (string)sqlReader["ZonaRisc"];
                        double viteza = (double)sqlReader["Viteza"];

                        Vehicule vehicul = new Vehicule(id, tipVehicul, nrRutei, locatia, disponibil, utilizat, functionare, timpSosire, problemeTehnice, nivelCombustibil, punctInteres, nrCalatori, zonaRisc, viteza);
                        _vehicule.Add(vehicul);
                    }
                }
            }
        }
        private void DeleteVehicul(Vehicule vehicul)
        {
            const string stringSql = "DELETE FROM Vehicul WHERE Id=@id";
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand(stringSql, connection);
                command.Parameters.AddWithValue("@id", vehicul.Id);
                command.ExecuteNonQuery();
                _vehicule.Remove(vehicul);
            }
        }
        private void adaugăVehiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehicule addVehicule = new AddVehicule();
            this.Hide();
            addVehicule.Closed += (s, args) => this.Show();
            addVehicule.ShowDialog();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadVehicule();
                DisplayVehicule();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            
            try
            {
                LoadVehicule();
                DisplayVehicule();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void adaugăVehiculeCuProblemeTehniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVehiculeProblem addVehiculeProblem = new AddVehiculeProblem();
            this.Hide();
            addVehiculeProblem.Closed += (s, args) => this.Show();
            addVehiculeProblem.ShowDialog();
        }

        private void adaugăNivelulDeCombustibilPentruVehiculeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNivelCombustibil addNivelCombustibil = new AddNivelCombustibil();
            this.Hide();
            addNivelCombustibil.Closed += (s, args) => this.Show();
            addNivelCombustibil.ShowDialog();
        }

        private void adaugăVitezaFiecăruiVehiculToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVitezaVehicol addVitezaVehicol = new AddVitezaVehicol();
            this.Hide();
            addVitezaVehicol.Closed += (s, args) => this.Show();
            addVitezaVehicol.ShowDialog();
        }

        private void adaugăPuncteleDeInteresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPunctInteres addPunctInteres = new AddPunctInteres();
            this.Hide();
            addPunctInteres.Closed += (s, args) => this.Show();
            addPunctInteres.ShowDialog();
        }

        private void adaugăNumărulDeCălătoriPentruFiecareTraseuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNrCalatori addNrCalatori = new AddNrCalatori();
            this.Hide();
            addNrCalatori.Closed += (s, args) => this.Show();
            addNrCalatori.ShowDialog();
        }

        private void adaugăZoneleCuRiscDeAccidenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddZoneRisc addZoneRisc = new AddZoneRisc();
            this.Hide();
            addZoneRisc.Closed += (s, args) => this.Show();
            addZoneRisc.ShowDialog();
        }

        private void adaugăTimpulTraseuluiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTimpSosireVehicol addTimpSosireVehicol = new AddTimpSosireVehicol();
            this.Hide();
            addTimpSosireVehicol.Closed += (s, args) => this.Show();
            addTimpSosireVehicol.ShowDialog();
        }

        private void ștergereVehiculToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvVehicule.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecteaza vehicul!");
                return;
            }
            if (MessageBox.Show("Sunteti increzuti?", "Stergere vehicul", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ListViewItem selectedItem = lvVehicule.SelectedItems[0];
                    Vehicule vehicul = (Vehicule)selectedItem.Tag;

                    DeleteVehicul(vehicul);
                    DisplayVehicule();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
