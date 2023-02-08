using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_1_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelfondo.Controls.Count > 0)
                this.panelfondo.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelfondo.Controls.Add(fh);
            this.panelfondo.Tag = fh;
            fh.Show();
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnrestaurar.Visible = true;
            btnmaximizar.Visible = false;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;

        }

        private void btnminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnrayas_Click(object sender, EventArgs e)
        {
            if (panelizq.Width == 183)
            {
                panelizq.Width = 57;
            }
            else
                panelizq.Width = 183;
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            Form formularioventas = new Ventas();
            formularioventas.Show();
            formularioventas.Visible = true;
            Visible = false;
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
           


        }

        private void AbrirFormhijo(object formhijo)
        {
            if (this.panelfondo.Controls.Count > 0)
                this.panelfondo.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelfondo.Controls.Add(fh);
            this.panelfondo.Tag = fh;
            fh.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

        }

        private void btnproducto_Click(object sender, EventArgs e)
        {
           
        }

        private void btnreparar_Click(object sender, EventArgs e)
        {
            Form formularioreparacion = new Reparacion();
            formularioreparacion.Show();
            formularioreparacion.Visible = true;
            Visible = false;
        }

        private void panelfondo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            Form formularioempleados = new Empleados();
            formularioempleados.Show();
            formularioempleados.Visible = true;
            Visible = false;
        }

        private void btnfacturas_Click(object sender, EventArgs e)
        {

        }

        private void btnhackearr_Click(object sender, EventArgs e)
        {
            Form formulariohackear = new Hackear();
            formulariohackear.Show();
            formulariohackear.Visible = true;
            Visible = false;
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            Form formularioalmacen = new Almacen();
            formularioalmacen.Show();
            formularioalmacen.Visible = true;
            Visible = false;
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            Form formularioventa = new Venta();
            formularioventa.Show();
            formularioventa.Visible = true;
            Visible = false;
        }

        private void btnalmacen_Click(object sender, EventArgs e)
        {
            Form formularioalmacen = new Almacen();
            formularioalmacen.Show();
            formularioalmacen.Visible = true;
            Visible = false;
        }
    }
}
