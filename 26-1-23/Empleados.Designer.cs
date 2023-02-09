namespace _26_1_23
{
    partial class Empleados
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
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnbuscarempleado = new System.Windows.Forms.Button();
            this.btneliminarempleado = new System.Windows.Forms.Button();
            this.bntagregarempleado = new System.Windows.Forms.Button();
            this.btnempleado = new System.Windows.Forms.Button();
            this.btninicio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Estadocivil = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Danielys Fdez",
            "Jean Carlos",
            "Gilbert",
            "Aycha"});
            this.comboBox6.Location = new System.Drawing.Point(83, 268);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(132, 21);
            this.comboBox6.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(250, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 14);
            this.label1.TabIndex = 42;
            this.label1.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 14);
            this.label4.TabIndex = 45;
            this.label4.Text = "Nombre completo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 14);
            this.label6.TabIndex = 47;
            this.label6.Text = "Num Documento:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(126, 113);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(198, 20);
            this.textBox4.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Datos del empleado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Usuario,
            this.Genero,
            this.Estadocivil,
            this.Puesto});
            this.dataGridView1.Location = new System.Drawing.Point(12, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 200);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnbuscarempleado
            // 
            this.btnbuscarempleado.FlatAppearance.BorderSize = 0;
            this.btnbuscarempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarempleado.Image = global::_26_1_23.Properties.Resources.agregar;
            this.btnbuscarempleado.Location = new System.Drawing.Point(475, 3);
            this.btnbuscarempleado.Name = "btnbuscarempleado";
            this.btnbuscarempleado.Size = new System.Drawing.Size(102, 67);
            this.btnbuscarempleado.TabIndex = 61;
            this.btnbuscarempleado.Text = "Buscar empleado";
            this.btnbuscarempleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnbuscarempleado.UseVisualStyleBackColor = true;
            // 
            // btneliminarempleado
            // 
            this.btneliminarempleado.FlatAppearance.BorderSize = 0;
            this.btneliminarempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminarempleado.Image = global::_26_1_23.Properties.Resources.basura;
            this.btneliminarempleado.Location = new System.Drawing.Point(686, 3);
            this.btneliminarempleado.Name = "btneliminarempleado";
            this.btneliminarempleado.Size = new System.Drawing.Size(102, 67);
            this.btneliminarempleado.TabIndex = 58;
            this.btneliminarempleado.Text = "Eliminar empleado";
            this.btneliminarempleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminarempleado.UseVisualStyleBackColor = true;
            // 
            // bntagregarempleado
            // 
            this.bntagregarempleado.FlatAppearance.BorderSize = 0;
            this.bntagregarempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntagregarempleado.Image = global::_26_1_23.Properties.Resources.agregar;
            this.bntagregarempleado.Location = new System.Drawing.Point(578, 3);
            this.bntagregarempleado.Name = "bntagregarempleado";
            this.bntagregarempleado.Size = new System.Drawing.Size(102, 67);
            this.bntagregarempleado.TabIndex = 57;
            this.bntagregarempleado.Text = "Agregar empleado";
            this.bntagregarempleado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntagregarempleado.UseVisualStyleBackColor = true;
            // 
            // btnempleado
            // 
            this.btnempleado.FlatAppearance.BorderSize = 0;
            this.btnempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempleado.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleado.ForeColor = System.Drawing.Color.Black;
            this.btnempleado.Image = global::_26_1_23.Properties.Resources.empleados__2_;
            this.btnempleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnempleado.Location = new System.Drawing.Point(1, 3);
            this.btnempleado.Name = "btnempleado";
            this.btnempleado.Size = new System.Drawing.Size(173, 53);
            this.btnempleado.TabIndex = 7;
            this.btnempleado.Text = "    Usuarios";
            this.btnempleado.UseVisualStyleBackColor = false;
            // 
            // btninicio
            // 
            this.btninicio.FlatAppearance.BorderSize = 0;
            this.btninicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninicio.Image = global::_26_1_23.Properties.Resources.iniciar_sesion;
            this.btninicio.Location = new System.Drawing.Point(699, 431);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(83, 84);
            this.btninicio.TabIndex = 76;
            this.btninicio.Text = "Volver a pagina de inicio";
            this.btninicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 80;
            this.label3.Text = "Puesto:";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Fdez Danielys",
            "Jean Carlos De Leon",
            "Aysha Cerda"});
            this.comboBox5.Location = new System.Drawing.Point(308, 268);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 79;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(467, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 14);
            this.label9.TabIndex = 82;
            this.label9.Text = "Contraseña:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cajero",
            "Hacker",
            "Reparador",
            "Delivery"});
            this.comboBox1.Location = new System.Drawing.Point(83, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 83;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 85;
            this.label2.Text = "Acceso:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(551, 268);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(104, 20);
            this.textBox2.TabIndex = 86;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre completo";
            this.Nombre.Name = "Nombre";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Genero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Estadocivil
            // 
            this.Estadocivil.HeaderText = "Estado civil";
            this.Estadocivil.Name = "Estadocivil";
            this.Estadocivil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estadocivil.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.Name = "Puesto";
            this.Puesto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Puesto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(793, 537);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.btnbuscarempleado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btneliminarempleado);
            this.Controls.Add(this.bntagregarempleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.btnempleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnempleado;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bntagregarempleado;
        private System.Windows.Forms.Button btneliminarempleado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnbuscarempleado;
        private System.Windows.Forms.Button btninicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewComboBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewComboBoxColumn Genero;
        private System.Windows.Forms.DataGridViewComboBoxColumn Estadocivil;
        private System.Windows.Forms.DataGridViewComboBoxColumn Puesto;
    }
}