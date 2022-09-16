using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_tienda
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Playeras playeras = new Playeras();
            this.Hide();
            playeras.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hoodies hoodies = new Hoodies();
            this.Hide();
            hoodies.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Accesorios accesorios = new Accesorios();
            this.Hide();
            accesorios.Show();
        }
    }
}
