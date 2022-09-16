using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_tienda
{
    public class Administrador
    {
        private string email;
        private string password;
        public string Email { get; set; }
        public string Password { get; set; }

        public bool Login(string _email, string _password)
        {
            this.email = _email;
            this.password = _password;

            if (this.email == "alumno@uat.edu.mx" && this.password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
