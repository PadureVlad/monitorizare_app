using Microsoft.Data.Sqlite;
using Monitorizare.AdminForms;
using Monitorizare.Class;
using Monitorizare.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitorizare.Forms
{
    public partial class UserForm : Form
    {
        private const string ConnectionString = "Data Source = Monitorizare.db"; //Initializam conectiunea cu baza de date
        private readonly List<Vehicule> _vehicule;
        public UserForm()
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

        private void UserForm_Load(object sender, EventArgs e)
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

        private void afișeazăListaDeVehiculeDisponibileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewVehiculeDisponibile viewVehiculeDisponibile = new ViewVehiculeDisponibile();
            this.Hide();
            viewVehiculeDisponibile.Closed += (s, args) => this.Show();
            viewVehiculeDisponibile.ShowDialog();
        }

        private void afișeazăVehiculeleCeAuProblemeTehniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewVehiculeProblemeTehnice viewVehiculeProbleme = new ViewVehiculeProblemeTehnice();
            this.Hide();
            viewVehiculeProbleme.Closed += (s, args) => this.Show();
            viewVehiculeProbleme.ShowDialog();
        }

        private void afișeazăNivelulDeCombustibilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonitorizeazaNivelCombustibil monitorizeazaNivelCombustibil = new MonitorizeazaNivelCombustibil();
            this.Hide();
            monitorizeazaNivelCombustibil.Closed += (s, args) => this.Show();
            monitorizeazaNivelCombustibil.ShowDialog();
        }

        private void afișeazăVitezaVehiculelorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonitorizeazaVitezaVehicul monitorizeazaVitezaVehicul = new MonitorizeazaVitezaVehicul();
            this.Hide();
            monitorizeazaVitezaVehicul.Closed += (s, args) => this.Show();
            monitorizeazaVitezaVehicul.ShowDialog();
        }

        private void afișeazăTraseeleCeleMaiUtilizateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTraseuUtilizat viewTraseuUtilizat = new ViewTraseuUtilizat();
            this.Hide();
            viewTraseuUtilizat.Closed += (s, args) => this.Show();
            viewTraseuUtilizat.ShowDialog();
        }

        private void afișeazăPuncteleDeInteresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewPuncteInteres viewPuncteInteres = new ViewPuncteInteres();
            this.Hide();
            viewPuncteInteres.Closed += (s, args) => this.Show();
            viewPuncteInteres.ShowDialog();
        }

        private void afișeazăZoneleDeRiscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewZoneRisc viewZoneRisc = new ViewZoneRisc();
            this.Hide();
            viewZoneRisc.Closed += (s, args) => this.Show();
            viewZoneRisc.ShowDialog();
        }

        private void afișeazăTimpulDeSosireAVehiculelorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTimpSosire viewTimpSosire = new ViewTimpSosire();
            this.Hide();
            viewTimpSosire.Closed += (s, args) => this.Show();
            viewTimpSosire.ShowDialog();
        }

        private void afișeazăNumărulDePasageriPentruFiecareTraseuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewNumarPasageri viewNumarPasageri = new ViewNumarPasageri();
            this.Hide();
            viewNumarPasageri.Closed += (s, args) => this.Show();
            viewNumarPasageri.ShowDialog();
        }
    }
}
