using Microsoft.Data.Sqlite;
using Monitorizare.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitorizare.Forms
{
    public partial class RestoreForm1 : Form
    {
        public long ID { get; set; }
        public string LogIn { get; set; }
        private const string ConnectionString = "Data Source = Monitorizare.db";
        private readonly List<Utilizatori> _utilizatori;
        private UtilizatoriContex context;
        public RestoreForm1()
        {
            InitializeComponent();
            _utilizatori = new List<Utilizatori>();
            context = new UtilizatoriContex(ConnectionString);
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
            if (tbPassword.Text == tbConfirmPassword.Text)
            {
                foreach (Utilizatori item in _utilizatori)
                {
                    try
                    {
						if (ID == item.Id)
						{
							try
							{
								Utilizatori utilizator = new Utilizatori()
								{
									Id = ID,
									Login = LogIn,
									Password = tbPassword.Text
								};
								context.UpdatePassword(utilizator);
								MessageBox.Show("Parola a fost modificata cu succes!");
								tbPassword.Text = "";
								tbConfirmPassword.Text = "";
							}
							catch (Exception ex)
							{
								MessageBox.Show(ex.Message);
							}
						}
					}
                    catch (Exception ex)
                    {
						MessageBox.Show(ex.Message);
					}
                }
            }
            else
            {
                MessageBox.Show("Parolele nu coincid!");
            }
            
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
            {
                tbPassword.PasswordChar = default(char);
            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
        }

        private void cbConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConfirmPassword.Checked)
            {
                tbConfirmPassword.PasswordChar = default(char);
            }
            else
            {
                tbConfirmPassword.PasswordChar = '*';
            }
        }

        private void RestoreForm1_Load(object sender, EventArgs e)
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
