using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitorizare.Class
{
    public class UtilizatoriContex : IDisposable
    {
        private readonly SqliteConnection _connection;

        public UtilizatoriContex(string connectionString)
        {
            _connection = new SqliteConnection(connectionString);
            _connection.Open();
        }
        public void UpdatePassword(Utilizatori utilizator)
        {
            using (var connection = _connection)
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "UPDATE Utilizator SET Login = $Login, Password = $Password" +
                    " WHERE Id_User = $Id";
                command.Parameters.AddWithValue("$Id", utilizator.Id);
                command.Parameters.AddWithValue("$Login", utilizator.Login);
                command.Parameters.AddWithValue("$Password", utilizator.Password);

                int rowsUpdated = command.ExecuteNonQuery();
                if (rowsUpdated != 1)
                {
                    throw new Exception("A fost o problema la modificarea parolei in baza de date!");
                }
            }
        }
        public void Dispose()
        {
            _connection.Close();
        }
    }
}
