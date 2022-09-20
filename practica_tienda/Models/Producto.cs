using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_tienda.Models
{
    public class Producto
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Producto(string name, string desc, int price, int quantity)
        {
            this.Name = name;
            this.Desc = desc;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
