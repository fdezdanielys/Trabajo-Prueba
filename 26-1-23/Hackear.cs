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
    public partial class Hackear : Form
    {
        public Hackear()
        {
            InitializeComponent();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            Form formularioinicio = new Form1();
            formularioinicio.Show();
            formularioinicio.Visible = true;
            Visible = false;
        }
    }
}
