using Microsoft.Data.Sqlite;
using Monitorizare.Class;
using Monitorizare.Forms;

namespace Monitorizare
{
    public partial class Form1 : Form
    {
        //Inițializam conecțiunea cu baza de date
        private const string ConnectionString = "Data Source = Monitorizare.db";
        //Inițializam o listă cu utilizatori
        private readonly List<Utilizatori> _utilizatori;
        public Form1()
        {
            InitializeComponent();
            _utilizatori = new List<Utilizatori>();
        }
        //Procedura LoadUtilizatori care selectează toți utilizatorii din baza de date și îi scrie în listă
        private void LoadUtilizatori()
        {
            const string stringSql = "SELECT * FROM Utilizator";//stringul SQL
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();//deschiderea conecțiunii
                var command = new SqliteCommand(stringSql, connection);
                using (SqliteDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        long id = (long)sqlReader["Id_User"];
                        string login = (string)sqlReader["Login"];
                        string password = (string)sqlReader["Password"];

                        Utilizatori utilizator = new Utilizatori(id, login, password);//apelul constructorului
                        _utilizatori.Add(utilizator);//adăugarea în listă a utilizatorului
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

        private void btConect_Click(object sender, EventArgs e)
        {
            string login = "", parola = "";
            foreach (Utilizatori item in _utilizatori)
            {
                if (tbLogin.Text == item.Login && tbPassword.Text == item.Password)
                {
                    login = item.Login;
                    parola = item.Password;
                }
            }
            if (tbLogin.Text == "" && tbPassword.Text == "")
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
            else if (tbLogin.Text == "admin" && tbPassword.Text == "admin")
            {
                AdminForm adminForm = new AdminForm();
                this.Hide();
                adminForm.Closed += (s, args) => this.Show();
                adminForm.ShowDialog();
            }
            else if (tbLogin.Text == login && tbPassword.Text == parola)
            {
                UserForm userForm = new UserForm();
                this.Hide();
                userForm.Closed += (s, args) => this.Show();
                userForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login sau Parola incorecta!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbLogin.Text = "";
            tbPassword.Text = "";
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.Closed += (s, args) => this.Show();
            registerForm.ShowDialog();
            LoadUtilizatori();
        }

        private void lbkForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbLogin.Text = "";
            tbPassword.Text = "";
            RestoreForm restoreForm = new RestoreForm();
            this.Hide();
            restoreForm.Closed += (s, args) => this.Show();
            restoreForm.ShowDialog();
            LoadUtilizatori();
        }

        private void btGuest_Click(object sender, EventArgs e)
        {
            tbLogin.Text = "";
            tbPassword.Text = "";
            GuestForm guestForm = new GuestForm();
            this.Hide();
            guestForm.Closed += (s, args) => this.Show();
            guestForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
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