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

namespace Monitorizare.Forms
{
    public partial class RestoreForm : Form
    {
        private long? id;
        private string? logIn;
        private const string ConnectionString = "Data Source = Monitorizare.db";
        private readonly List<Utilizatori> _utilizatori;
        public RestoreForm()
        {
            InitializeComponent();
            _utilizatori = new List<Utilizatori>();
        }
        private void LoadUtilizatori()
        {
            const string stringSql = "SELECT * FROM Utilizator";
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqliteCommand(stringSql, connection);
                using (SqliteDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        long id = (long)sqlReader["Id_User"];
                        string login = (string)sqlReader["Login"];
                        string password = (string)sqlReader["Password"];

                        Utilizatori utilizator = new Utilizatori(id, login, password);
                        _utilizatori.Add(utilizator);
                    }
                }
            }
        }
        private void btRestore_Click(object sender, EventArgs e)
        {
            int s = 0;
            foreach (Utilizatori item in _utilizatori)
            {
                if (tbLogin.Text == item.Login)
                {
                    id = (long?)item.Id;
                    logIn = item.Login;
                    RestoreForm1 restoreForm1 = new RestoreForm1();
                    restoreForm1.ID = (long)id;
                    restoreForm1.LogIn = logIn;
                    this.Hide();
                    restoreForm1.Closed += (s, args) => this.Close();
                    restoreForm1.ShowDialog();
                    s++;
                }
            }
            if (s < 1)
            {
                MessageBox.Show("Utilizatorul nu a fost gasit!");
            }
            if (tbLogin.Text == "")
            {
                MessageBox.Show("Introduceti login-ul!");
            }
        }

        private void RestoreForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadUtilizatori();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
