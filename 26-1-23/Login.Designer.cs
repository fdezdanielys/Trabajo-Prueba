namespace _26_1_23
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.insertarcontraseña = new System.Windows.Forms.TextBox();
            this.insertarusuario = new System.Windows.Forms.ComboBox();
            this.btniniciar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnminizar = new System.Windows.Forms.Button();
            this.btnusuario = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // insertarcontraseña
            // 
            this.insertarcontraseña.BackColor = System.Drawing.Color.White;
            this.insertarcontraseña.Enabled = false;
            this.insertarcontraseña.Location = new System.Drawing.Point(162, 147);
            this.insertarcontraseña.Name = "insertarcontraseña";
            this.insertarcontraseña.Size = new System.Drawing.Size(200, 20);
            this.insertarcontraseña.TabIndex = 2;
            this.insertarcontraseña.Enter += new System.EventHandler(this.insertarcontraseña_Enter);
            this.insertarcontraseña.Leave += new System.EventHandler(this.insertarcontraseña_Leave);
            // 
            // insertarusuario
            // 
            this.insertarusuario.BackColor = System.Drawing.Color.White;
            this.insertarusuario.Enabled = false;
            this.insertarusuario.FormattingEnabled = true;
            this.insertarusuario.Items.AddRange(new object[] {
            "Danielys Fdez",
            "Jean Carlos Leon",
            "Gilbert Tavarez",
            "Aysha Cerda"});
            this.insertarusuario.Location = new System.Drawing.Point(162, 83);
            this.insertarusuario.Name = "insertarusuario";
            this.insertarusuario.Size = new System.Drawing.Size(200, 21);
            this.insertarusuario.TabIndex = 1;
            this.insertarusuario.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.insertarusuario.Leave += new System.EventHandler(this.insertarusuario_Leave);
            // 
            // btniniciar
            // 
            this.btniniciar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btniniciar.FlatAppearance.BorderSize = 0;
            this.btniniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniniciar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciar.Location = new System.Drawing.Point(152, 200);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(90, 31);
            this.btniniciar.TabIndex = 3;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = false;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            this.btniniciar.MouseLeave += new System.EventHandler(this.Login_Load);
            this.btniniciar.MouseHover += new System.EventHandler(this.Login_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnminizar);
            this.panel1.Controls.Add(this.btnusuario);
            this.panel1.Controls.Add(this.insertarusuario);
            this.panel1.Controls.Add(this.insertarcontraseña);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 258);
            this.panel1.TabIndex = 53;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // btnminizar
            // 
            this.btnminizar.FlatAppearance.BorderSize = 0;
            this.btnminizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminizar.Image = global::_26_1_23.Properties.Resources.borrar;
            this.btnminizar.Location = new System.Drawing.Point(470, -3);
            this.btnminizar.Name = "btnminizar";
            this.btnminizar.Size = new System.Drawing.Size(30, 31);
            this.btnminizar.TabIndex = 47;
            this.btnminizar.UseVisualStyleBackColor = true;
            this.btnminizar.Click += new System.EventHandler(this.btnminizar_Click);
            // 
            // btnusuario
            // 
            this.btnusuario.BackColor = System.Drawing.Color.White;
            this.btnusuario.Enabled = false;
            this.btnusuario.Location = new System.Drawing.Point(162, 40);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(200, 20);
            this.btnusuario.TabIndex = 4;
            this.btnusuario.Enter += new System.EventHandler(this.btnusuario_Enter);
            this.btnusuario.Leave += new System.EventHandler(this.btnusuario_Leave);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(263, 200);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(90, 31);
            this.btncancelar.TabIndex = 52;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.FlatAppearance.BorderSize = 0;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Image = global::_26_1_23.Properties.Resources.cerrar;
            this.btncerrar.Location = new System.Drawing.Point(499, -3);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(27, 31);
            this.btncerrar.TabIndex = 46;
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::_26_1_23.Properties.Resources.candado;
            this.label3.Location = new System.Drawing.Point(100, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 50);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::_26_1_23.Properties.Resources.perfil__1_;
            this.label2.Location = new System.Drawing.Point(97, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 60);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = global::_26_1_23.Properties.Resources.programador;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "     Inicio De Sesion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(528, 258);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox insertarcontraseña;
        private System.Windows.Forms.ComboBox insertarusuario;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox btnusuario;
        private System.Windows.Forms.Button btnminizar;
    }
}