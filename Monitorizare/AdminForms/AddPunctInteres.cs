using Microsoft.Data.Sqlite;
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
    public partial class AddPunctInteres : Form
    {
        private string connectionString = "Data Source = Monitorizare.db";
        private readonly SqliteConnection _connection;
        public AddPunctInteres()
        {
            InitializeComponent();
            _connection = new SqliteConnection(connectionString);
        }

        private void btAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = _connection)
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = "UPDATE Vehicul SET PunctInteres = $PunctInteres" +
                        " WHERE Id = $Id";
                    command.Parameters.AddWithValue("$Id", Convert.ToInt32(tbId.Text));
                    command.Parameters.AddWithValue("$PunctInteres", tbPunctInteres.Text);
                    int rowsUpdated = command.ExecuteNonQuery();
                    if (rowsUpdated != 1)
                    {
                        throw new Exception("A fost o problema la modificarea datelor in baza de date!");
                    }
                    tbId.Text = "";
                    tbPunctInteres.Text = "";
                    MessageBox.Show("Datele au fost modificate cu succes!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Eroare. Nu exista vehicol cu acest ID!");
            }
        }

        private void tbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
