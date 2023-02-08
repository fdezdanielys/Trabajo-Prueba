namespace _26_1_23
{
    partial class Factura
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
            this.btnfactura = new System.Windows.Forms.Button();
            this.btninicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfactura
            // 
            this.btnfactura.BackColor = System.Drawing.Color.Silver;
            this.btnfactura.FlatAppearance.BorderSize = 0;
            this.btnfactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfactura.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfactura.ForeColor = System.Drawing.Color.Black;
            this.btnfactura.Image = global::_26_1_23.Properties.Resources.factura__3_;
            this.btnfactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfactura.Location = new System.Drawing.Point(4, 1);
            this.btnfactura.Name = "btnfactura";
            this.btnfactura.Size = new System.Drawing.Size(173, 53);
            this.btnfactura.TabIndex = 1;
            this.btnfactura.Text = "Factura";
            this.btnfactura.UseVisualStyleBackColor = false;
            // 
            // btninicio
            // 
            this.btninicio.FlatAppearance.BorderSize = 0;
            this.btninicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninicio.Image = global::_26_1_23.Properties.Resources.iniciar_sesion;
            this.btninicio.Location = new System.Drawing.Point(894, 441);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(83, 84);
            this.btninicio.TabIndex = 63;
            this.btninicio.Text = "Volver a pagina de inicio";
            this.btninicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(989, 537);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.btnfactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Factura";
            this.Text = "Factura";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfactura;
        private System.Windows.Forms.Button btninicio;
    }
}