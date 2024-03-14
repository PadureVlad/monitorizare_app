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
    public partial class ViewTimpSosire : Form
    {
        private const string ConnectionString = "Data Source = Monitorizare.db"; //Initializam conectiunea cu baza de date
        private readonly List<Vehicule> _vehicule;
        public ViewTimpSosire()
        {
            InitializeComponent();
            _vehicule= new List<Vehicule>();
        }
        private void DisplayVehicule()
        {
            lvVehicule.Items.Clear();
            foreach (Vehicule vehicul in _vehicule)
            {
                if (vehicul.Utilizat == "Da")
                {
                    var listViewItem = new ListViewItem(vehicul.Id.ToString());
                    listViewItem.SubItems.Add(vehicul.TipVehicul);
                    listViewItem.SubItems.Add(vehicul.NrRutei);
                    listViewItem.SubItems.Add(vehicul.TimpulSosire);
                    listViewItem.SubItems.Add(vehicul.Locatia);
                    listViewItem.SubItems.Add(vehicul.NrCalatori.ToString());
                    listViewItem.SubItems.Add(vehicul.Viteza.ToString());
                    listViewItem.Tag = vehicul;
                    lvVehicule.Items.Add(listViewItem);
                }
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

        private void ViewTimpSosire_Load(object sender, EventArgs e)
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
