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
    public partial class RegisterForm : Form
    {
        private const string ConnectionString = "Data Source = Monitorizare.db";
        private readonly List<Utilizatori> _utilizatori;
        public RegisterForm()
        {
            InitializeComponent();
            _utilizatori = new List<Utilizatori>();
        }
        private void AddUtilizatori(Utilizatori utilizator)
        {
            var queryString = "insert into Utilizator(Login, Password)" +
                " values(@login, @password); " +
                "SELECT last_insert_rowid()";
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqliteCommand(queryString, connection);
                command.Parameters.AddWithValue("@login", utilizator.Login);
                command.Parameters.AddWithValue("@password", utilizator.Password);

                utilizator.Id = (long?)command.ExecuteScalar();

                _utilizatori.Add(utilizator);
            }
        }
        private void LoadUtilizator()
        {
            _utilizatori.Clear();
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

        private void btRegister_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (tbPassword.Text == tbConfirmPassword.Text)
            {
                var login = tbLogin.Text;
                var password = tbPassword.Text;
                foreach (Utilizatori item in _utilizatori)
                {
                    if (item.Login == login && item.Password == password)
                    {
                        s++;
                        MessageBox.Show("Exista asa utilizator cu aceste date! \nIntroduceti alte date!");
                    }
                }
                if (login == "admin" || password == "admin")
                {
                    MessageBox.Show("Nu puteti folosi datele administratorului! \nIntroduceti alte date!");
                }
                else if (tbLogin.Text == "" && tbPassword.Text == "")
                {
                    MessageBox.Show("Introduceti login-ul si parola!");
                }
                else if (tbLogin.Text == "")
                {
                    MessageBox.Show("Introduceti login-ul!");
                }
                else if (tbPassword.Text == "")
                {
                    MessageBox.Show("Introduceti parola!");
                }
                else if (s < 1)
                {
                    var utilizator = new Utilizatori(login, password);
                    try
                    {
                        AddUtilizatori(utilizator);
                        MessageBox.Show("Utilizatorul a fost adaugat cu succes!");
                        tbLogin.Text = "";
                        tbPassword.Text = "";
                        tbConfirmPassword.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nu coincid parolele!");
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadUtilizator();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
