namespace _26_1_23
{
    partial class Ventas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Codigodearras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preciocompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btninicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Codigodearras,
            this.Preciocompra,
            this.Precioventa,
            this.Marca,
            this.Modelo,
            this.Cantidad,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(12, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto:";
            this.Producto.Name = "Producto";
            this.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Codigodearras
            // 
            this.Codigodearras.HeaderText = "Codigo de barras:";
            this.Codigodearras.Name = "Codigodearras";
            // 
            // Preciocompra
            // 
            this.Preciocompra.HeaderText = "Precio de compra:";
            this.Preciocompra.Name = "Preciocompra";
            // 
            // Precioventa
            // 
            this.Precioventa.HeaderText = "Precio de venta:";
            this.Precioventa.Name = "Precioventa";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca:";
            this.Marca.Name = "Marca";
            this.Marca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Marca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo:";
            this.Modelo.Name = "Modelo";
            this.Modelo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modelo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad:";
            this.Cantidad.Name = "Cantidad";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total:";
            this.Total.Name = "Total";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::_26_1_23.Properties.Resources.compras__2_;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(406, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "      Ventas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.White;
            this.btnmodificar.FlatAppearance.BorderSize = 0;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Image = global::_26_1_23.Properties.Resources.editar;
            this.btnmodificar.Location = new System.Drawing.Point(79, 76);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(60, 58);
            this.btnmodificar.TabIndex = 2;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.White;
            this.btnnuevo.FlatAppearance.BorderSize = 0;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Image = global::_26_1_23.Properties.Resources.boton_mas__1_;
            this.btnnuevo.Location = new System.Drawing.Point(12, 76);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(61, 58);
            this.btnnuevo.TabIndex = 1;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
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
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(989, 537);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigodearras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preciocompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precioventa;
        private System.Windows.Forms.DataGridViewComboBoxColumn Marca;
        private System.Windows.Forms.DataGridViewComboBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btninicio;
    }
}