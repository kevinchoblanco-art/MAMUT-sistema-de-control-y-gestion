namespace SistemaProveedores
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.textdireccion = new System.Windows.Forms.TextBox();
            this.texttelefono = new System.Windows.Forms.TextBox();
            this.texttipo = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.ComboBox();
            this.MODIFICAR = new System.Windows.Forms.Button();
            this.AGREGAR = new System.Windows.Forms.Button();
            this.CONSULTAR = new System.Windows.Forms.Button();
            this.ELIMINAR = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LIMPIAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-13, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(87, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "GESTION DE PROVEEDORES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "DIRECCION :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "TELEFONO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "TIPO DE PROV. :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "BUSCAR :";
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(168, 94);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(190, 20);
            this.textnombre.TabIndex = 8;
            // 
            // textdireccion
            // 
            this.textdireccion.Location = new System.Drawing.Point(168, 124);
            this.textdireccion.Name = "textdireccion";
            this.textdireccion.Size = new System.Drawing.Size(190, 20);
            this.textdireccion.TabIndex = 9;
            // 
            // texttelefono
            // 
            this.texttelefono.Location = new System.Drawing.Point(168, 154);
            this.texttelefono.Name = "texttelefono";
            this.texttelefono.Size = new System.Drawing.Size(190, 20);
            this.texttelefono.TabIndex = 10;
            // 
            // texttipo
            // 
            this.texttipo.Location = new System.Drawing.Point(168, 183);
            this.texttipo.Name = "texttipo";
            this.texttipo.Size = new System.Drawing.Size(190, 20);
            this.texttipo.TabIndex = 11;
            // 
            // textId
            // 
            this.textId.FormattingEnabled = true;
            this.textId.Location = new System.Drawing.Point(168, 212);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(189, 21);
            this.textId.TabIndex = 12;
            this.textId.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MODIFICAR
            // 
            this.MODIFICAR.BackColor = System.Drawing.Color.Chocolate;
            this.MODIFICAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MODIFICAR.Location = new System.Drawing.Point(12, 268);
            this.MODIFICAR.Name = "MODIFICAR";
            this.MODIFICAR.Size = new System.Drawing.Size(90, 32);
            this.MODIFICAR.TabIndex = 13;
            this.MODIFICAR.Text = "MODIFICAR";
            this.MODIFICAR.UseVisualStyleBackColor = false;
            this.MODIFICAR.Click += new System.EventHandler(this.MODIFICAR_Click);
            // 
            // AGREGAR
            // 
            this.AGREGAR.BackColor = System.Drawing.Color.Silver;
            this.AGREGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AGREGAR.Location = new System.Drawing.Point(108, 268);
            this.AGREGAR.Name = "AGREGAR";
            this.AGREGAR.Size = new System.Drawing.Size(90, 31);
            this.AGREGAR.TabIndex = 14;
            this.AGREGAR.Text = "AGREGAR";
            this.AGREGAR.UseVisualStyleBackColor = false;
            this.AGREGAR.Click += new System.EventHandler(this.AGREGAR_Click);
            // 
            // CONSULTAR
            // 
            this.CONSULTAR.BackColor = System.Drawing.Color.DarkGray;
            this.CONSULTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONSULTAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CONSULTAR.Location = new System.Drawing.Point(204, 268);
            this.CONSULTAR.Name = "CONSULTAR";
            this.CONSULTAR.Size = new System.Drawing.Size(90, 31);
            this.CONSULTAR.TabIndex = 15;
            this.CONSULTAR.Text = "CONSULTAR";
            this.CONSULTAR.UseVisualStyleBackColor = false;
            this.CONSULTAR.Click += new System.EventHandler(this.CONSULTAR_Click);
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ELIMINAR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ELIMINAR.Location = new System.Drawing.Point(396, 268);
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.Size = new System.Drawing.Size(90, 31);
            this.ELIMINAR.TabIndex = 16;
            this.ELIMINAR.Text = "ELIMINAR";
            this.ELIMINAR.UseVisualStyleBackColor = false;
            this.ELIMINAR.Click += new System.EventHandler(this.ELIMINAR_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 141);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LIMPIAR
            // 
            this.LIMPIAR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LIMPIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIMPIAR.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LIMPIAR.Location = new System.Drawing.Point(300, 268);
            this.LIMPIAR.Name = "LIMPIAR";
            this.LIMPIAR.Size = new System.Drawing.Size(90, 32);
            this.LIMPIAR.TabIndex = 18;
            this.LIMPIAR.Text = "LIMPIAR";
            this.LIMPIAR.UseVisualStyleBackColor = false;
            this.LIMPIAR.Click += new System.EventHandler(this.LIMPIAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 490);
            this.Controls.Add(this.LIMPIAR);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ELIMINAR);
            this.Controls.Add(this.CONSULTAR);
            this.Controls.Add(this.AGREGAR);
            this.Controls.Add(this.MODIFICAR);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.texttipo);
            this.Controls.Add(this.texttelefono);
            this.Controls.Add(this.textdireccion);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.TextBox textdireccion;
        private System.Windows.Forms.TextBox texttelefono;
        private System.Windows.Forms.TextBox texttipo;
        private System.Windows.Forms.ComboBox textId;
        private System.Windows.Forms.Button MODIFICAR;
        private System.Windows.Forms.Button AGREGAR;
        private System.Windows.Forms.Button CONSULTAR;
        private System.Windows.Forms.Button ELIMINAR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LIMPIAR;
    }
}

