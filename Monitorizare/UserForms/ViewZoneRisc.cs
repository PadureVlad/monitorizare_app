using Microsoft.Data.Sqlite;
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

namespace Monitorizare.UserForms
{
    public partial class ViewZoneRisc : Form
    {
        private const string ConnectionString = "Data Source = Monitorizare.db"; //Initializam conectiunea cu baza de date
        private readonly List<Vehicule> _vehicule;
        public ViewZoneRisc()
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
                listViewItem.SubItems.Add(vehicul.NrCalatori.ToString());
                listViewItem.SubItems.Add(vehicul.ZonaRisc);
                listViewItem.SubItems.Add(vehicul.Viteza.ToString("0.0 km/h"));
                listViewItem.Tag = vehicul;
                lvVehicule.Items.Add(listViewItem);
            }
            lbResult.Text = "Avertizare! În zonele de risc rugăm toți șoferii, pentru a evida accidentele, să reduceți viteza între 50-30 km/h!";
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
        private void ViewZoneRisc_Load(object sender, EventArgs e)
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
    }
}
