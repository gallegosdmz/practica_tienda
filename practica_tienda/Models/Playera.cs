using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_tienda.Models
{
    public class Playera : Producto
    {      
        public string Size { get; set; }
        public Playera(string name, string desc, int price, int stock, string size) 
            : base (name, desc, price, stock)
        {
            this.Size = size;
        }
    }
}
