using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_tienda.Models
{
    public class Cliente
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Cliente (string name, string surname, string phone, string email)
        {
            this.Name = name;
            this.Surname = surname;
            this.Phone = phone;
            this.Email = email;
        }
    }
}
