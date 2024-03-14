using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitorizare.Class
{
    public class Utilizatori
    {
        public long? Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Utilizatori(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public Utilizatori(long id, string login, string password) : this(login, password)
        {
            Id = id;
        }
        public Utilizatori() { }
    }
}
