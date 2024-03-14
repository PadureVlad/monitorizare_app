using Microsoft.Data.Sqlite;
using Monitorizare.Class;
using Monitorizare.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitorizare.AdminForms
{
    public partial class AddVehicule : Form
    {
        private const string ConnectionString = "Data Source = Monitorizare.db";
        private readonly List<Vehicule> _vehicule;
        public AddVehicule()
        {
            InitializeComponent();
            _vehicule = new List<Vehicule>(); 
        }
        private void AddVehicul(Vehicule vehicul)
        {
            var queryString = "insert into Vehicul(TipulVehiculului, NrRutei, Locatia, Disponibil, Utilizat, Functionare, TimpulSosire, ProblemeTehnice, NivelCombustibil, PunctInteres, NrCalatori, ZonaRisc, Viteza)" +
                " values(@tipVehicul, @nrRutei, @locatia, @disponibil, @utilizat, @functionare, @timpSosire, @problemeTehnice, @nivelCombustibil, @punctInteres, @nrCalatori, @zonaRisc, @viteza); " +
                "SELECT last_insert_rowid()";
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqliteCommand(queryString, connection);
                command.Parameters.AddWithValue("@tipVehicul", vehicul.TipVehicul);
                command.Parameters.AddWithValue("@nrRutei", vehicul.NrRutei);
                command.Parameters.AddWithValue("@locatia", vehicul.Locatia);
                command.Parameters.AddWithValue("@disponibil", vehicul.Disponibil);
                command.Parameters.AddWithValue("@utilizat", vehicul.Utilizat);
                command.Parameters.AddWithValue("@functionare", vehicul.Functionare);
                command.Parameters.AddWithValue("@timpSosire", vehicul.TimpulSosire);
                command.Parameters.AddWithValue("@problemeTehnice", vehicul.ProblemeTehnice);
                command.Parameters.AddWithValue("@nivelCombustibil", vehicul.NivelCombustibil);
                command.Parameters.AddWithValue("@punctInteres", vehicul.PunctInteres);
                command.Parameters.AddWithValue("@nrCalatori", vehicul.NrCalatori);
                command.Parameters.AddWithValue("@zonaRisc", vehicul.ZonaRisc);
                command.Parameters.AddWithValue("@viteza", vehicul.Viteza);

                vehicul.Id = (long?)command.ExecuteScalar();

                _vehicule.Add(vehicul);
            }
        }
        private void btAdauga_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTipulVehicul.Text) ||
                string.IsNullOrWhiteSpace(tbNumarulRutei.Text) ||
                string.IsNullOrWhiteSpace(tbLocatia.Text) ||
                string.IsNullOrWhiteSpace(tbDisponibil.Text) ||
                string.IsNullOrWhiteSpace(tbUtilizat.Text) ||
                string.IsNullOrWhiteSpace(tbFunctionare.Text))
            {
                MessageBox.Show("Nu sunt completate toate campurile necesare", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var tipVehicul = tbTipulVehicul.Text;
            var nrRutei = tbNumarulRutei.Text;
            var locatia = tbLocatia.Text;
            var disponibil = tbDisponibil.Text;
            var utilizat = tbUtilizat.Text;
            var functionare = tbFunctionare.Text;
            string timpSosire = "";
            string problemeTehnice = "";
            double nivelCombustibil = 0;
            string punctInteres = "";
            int nrCalatori = 0;
            string zonaRisc = "";
            double viteza = 0;

            var vehicul = new Vehicule(tipVehicul, nrRutei, locatia, disponibil, utilizat, functionare, timpSosire, problemeTehnice, nivelCombustibil, punctInteres, nrCalatori, zonaRisc, viteza);
            try
            {
                AddVehicul(vehicul);
                MessageBox.Show("Datele au fost adaugate cu succes!");
                tbTipulVehicul.Text = "";
                tbNumarulRutei.Text = "";
                tbLocatia.Text = "";
                tbDisponibil.Text = "";
                tbUtilizat.Text = "";
                tbFunctionare.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
