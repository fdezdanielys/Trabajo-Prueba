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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Login_Load(object sender, EventArgs e)
        {
            //Centrar el panel
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize; //Captura el tamaño del monitor 
            Int32 alto = (desktopSize.Height - 258) / 2;
            Int32 ancho = (desktopSize.Width - 528) / 2;
            panel1.Location = new Point(ancho, alto);
            //Fin centrar el panel
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (insertarusuario.Text == "USUARIO") {
                insertarusuario.Text = "";
                insertarusuario.ForeColor = Color.LightGray;

            }
        }

        private void btnusuario_Enter(object sender, EventArgs e)
        {
            if (btnusuario.Text == "USUARIO") {
                btnusuario.Text = "";
                btnusuario.ForeColor = Color.LightGray;

            }

        }

        private void insertarusuario_Leave(object sender, EventArgs e)
        {
            if (insertarusuario.Text == "")  {
                insertarusuario.Text = "USUARIO";
                insertarusuario.ForeColor = Color.White;

            }
        }

        private void btnusuario_Leave(object sender, EventArgs e)
        {
            if (btnusuario.Text == "") {
                btnusuario.Text = "USUARIO";
                btnusuario.ForeColor = Color.White;

            }

        }

        private void insertarcontraseña_Enter(object sender, EventArgs e)
        {
            if (insertarcontraseña.Text == "CONTRASEÑA") {
                insertarcontraseña.Text = "";
                insertarcontraseña.ForeColor = Color.LightGray;
                insertarcontraseña.UseSystemPasswordChar = true;

            }


        }

        private void insertarcontraseña_Leave(object sender, EventArgs e)
        {
          if  (insertarcontraseña.Text == "") {
                insertarcontraseña .Text = "CONTRASEÑA";
                insertarcontraseña .ForeColor = Color.White;
                insertarcontraseña.UseSystemPasswordChar = false;

            }


        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
