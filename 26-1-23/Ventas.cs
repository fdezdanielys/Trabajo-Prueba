using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_1_23
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Form formularioventa = new Venta();
            formularioventa.Show();
            formularioventa.Visible = true;
            Visible = false;
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            Form formularioinicio = new Form1();
            formularioinicio.Show();
            formularioinicio.Visible = true;
            Visible = false;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Form formularioventa = new Venta();
            formularioventa.Show();
            formularioventa.Visible = true;
            Visible = false;
        }
    }
}
