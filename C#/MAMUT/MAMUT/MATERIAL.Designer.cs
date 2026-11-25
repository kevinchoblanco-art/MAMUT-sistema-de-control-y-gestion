namespace MAMUT
{
    partial class MATERIAL
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
            this.DGBMATERIAL = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.GUARDAR = new System.Windows.Forms.Button();
            this.LIMPIAR = new System.Windows.Forms.Button();
            this.ELIMINAR = new System.Windows.Forms.Button();
            this.textIDPROVEEDOR = new System.Windows.Forms.TextBox();
            this.textIDPERSONAL = new System.Windows.Forms.TextBox();
            this.comboTIPO_MATERIAL = new System.Windows.Forms.ComboBox();
            this.FECHA_RECEP = new System.Windows.Forms.DateTimePicker();
            this.textCANTIDADKG = new System.Windows.Forms.TextBox();
            this.rbdisponible = new System.Windows.Forms.RadioButton();
            this.rbenprocesso = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TIPO_DE_MATERIAL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combobusqueda = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textbusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGBMATERIAL)).BeginInit();
            this.SuspendLayout();
            // 
            // DGBMATERIAL
            // 
            this.DGBMATERIAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBMATERIAL.Location = new System.Drawing.Point(230, 170);
            this.DGBMATERIAL.Name = "DGBMATERIAL";
            this.DGBMATERIAL.Size = new System.Drawing.Size(603, 318);
            this.DGBMATERIAL.TabIndex = 0;
            this.DGBMATERIAL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGBMATERIALES_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTION DE MATERIALES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GUARDAR
            // 
            this.GUARDAR.Location = new System.Drawing.Point(12, 327);
            this.GUARDAR.Name = "GUARDAR";
            this.GUARDAR.Size = new System.Drawing.Size(96, 23);
            this.GUARDAR.TabIndex = 2;
            this.GUARDAR.Text = "GUARDAR";
            this.GUARDAR.UseVisualStyleBackColor = true;
            this.GUARDAR.Click += new System.EventHandler(this.GUARDAR_Click);
            // 
            // LIMPIAR
            // 
            this.LIMPIAR.Location = new System.Drawing.Point(65, 374);
            this.LIMPIAR.Name = "LIMPIAR";
            this.LIMPIAR.Size = new System.Drawing.Size(96, 23);
            this.LIMPIAR.TabIndex = 3;
            this.LIMPIAR.Text = "LIMPIAR";
            this.LIMPIAR.UseVisualStyleBackColor = true;
            this.LIMPIAR.Click += new System.EventHandler(this.LIMPIAR_Click);
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.Location = new System.Drawing.Point(119, 327);
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.Size = new System.Drawing.Size(96, 23);
            this.ELIMINAR.TabIndex = 4;
            this.ELIMINAR.Text = "ELIMINAR";
            this.ELIMINAR.UseVisualStyleBackColor = true;
            this.ELIMINAR.Click += new System.EventHandler(this.ELIMINAR_Click);
            // 
            // textIDPROVEEDOR
            // 
            this.textIDPROVEEDOR.Location = new System.Drawing.Point(30, 59);
            this.textIDPROVEEDOR.Name = "textIDPROVEEDOR";
            this.textIDPROVEEDOR.Size = new System.Drawing.Size(141, 20);
            this.textIDPROVEEDOR.TabIndex = 5;
            // 
            // textIDPERSONAL
            // 
            this.textIDPERSONAL.Location = new System.Drawing.Point(30, 99);
            this.textIDPERSONAL.Name = "textIDPERSONAL";
            this.textIDPERSONAL.Size = new System.Drawing.Size(141, 20);
            this.textIDPERSONAL.TabIndex = 6;
            // 
            // comboTIPO_MATERIAL
            // 
            this.comboTIPO_MATERIAL.FormattingEnabled = true;
            this.comboTIPO_MATERIAL.Items.AddRange(new object[] {
            "Neumatico usado",
            "Caucho molido",
            "Neumatico pequeño",
            "Neumatico mediano"});
            this.comboTIPO_MATERIAL.Location = new System.Drawing.Point(30, 178);
            this.comboTIPO_MATERIAL.Name = "comboTIPO_MATERIAL";
            this.comboTIPO_MATERIAL.Size = new System.Drawing.Size(141, 21);
            this.comboTIPO_MATERIAL.TabIndex = 8;
            this.comboTIPO_MATERIAL.SelectedIndexChanged += new System.EventHandler(this.comboTIPO_MATERIAL_SelectedIndexChanged);
            // 
            // FECHA_RECEP
            // 
            this.FECHA_RECEP.Location = new System.Drawing.Point(12, 288);
            this.FECHA_RECEP.Name = "FECHA_RECEP";
            this.FECHA_RECEP.Size = new System.Drawing.Size(203, 20);
            this.FECHA_RECEP.TabIndex = 9;
            this.FECHA_RECEP.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textCANTIDADKG
            // 
            this.textCANTIDADKG.Location = new System.Drawing.Point(30, 139);
            this.textCANTIDADKG.Name = "textCANTIDADKG";
            this.textCANTIDADKG.Size = new System.Drawing.Size(141, 20);
            this.textCANTIDADKG.TabIndex = 7;
            // 
            // rbdisponible
            // 
            this.rbdisponible.AutoSize = true;
            this.rbdisponible.Checked = true;
            this.rbdisponible.Location = new System.Drawing.Point(32, 232);
            this.rbdisponible.Name = "rbdisponible";
            this.rbdisponible.Size = new System.Drawing.Size(89, 17);
            this.rbdisponible.TabIndex = 10;
            this.rbdisponible.TabStop = true;
            this.rbdisponible.Text = "DISPONIBLE";
            this.rbdisponible.UseVisualStyleBackColor = true;
            this.rbdisponible.CheckedChanged += new System.EventHandler(this.rbdisponible_CheckedChanged);
            // 
            // rbenprocesso
            // 
            this.rbenprocesso.AutoSize = true;
            this.rbenprocesso.Location = new System.Drawing.Point(32, 255);
            this.rbenprocesso.Name = "rbenprocesso";
            this.rbenprocesso.Size = new System.Drawing.Size(102, 17);
            this.rbenprocesso.TabIndex = 11;
            this.rbenprocesso.Text = "EN PROCESSO";
            this.rbenprocesso.UseVisualStyleBackColor = true;
            this.rbenprocesso.CheckedChanged += new System.EventHandler(this.rbenproceso_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = " ID_PROVEEDOR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID_PERSONAL";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "CANTIDAD (KG)";
            // 
            // TIPO_DE_MATERIAL
            // 
            this.TIPO_DE_MATERIAL.AutoSize = true;
            this.TIPO_DE_MATERIAL.Location = new System.Drawing.Point(27, 162);
            this.TIPO_DE_MATERIAL.Name = "TIPO_DE_MATERIAL";
            this.TIPO_DE_MATERIAL.Size = new System.Drawing.Size(107, 13);
            this.TIPO_DE_MATERIAL.TabIndex = 15;
            this.TIPO_DE_MATERIAL.Text = "TIPO DE MATERIAL";
            this.TIPO_DE_MATERIAL.Click += new System.EventHandler(this.TIPO_DE_MATERIAL_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "ESTADO";
            // 
            // combobusqueda
            // 
            this.combobusqueda.FormattingEnabled = true;
            this.combobusqueda.Items.AddRange(new object[] {
            "IdMaterial",
            "IdProveedor",
            "IdPersonal",
            "TipoMaterial"});
            this.combobusqueda.Location = new System.Drawing.Point(313, 139);
            this.combobusqueda.Name = "combobusqueda";
            this.combobusqueda.Size = new System.Drawing.Size(121, 21);
            this.combobusqueda.TabIndex = 17;
            this.combobusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "BUSCAR POR ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "CONSULTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCONSULTA_Click);
            // 
            // textbusqueda
            // 
            this.textbusqueda.Location = new System.Drawing.Point(589, 138);
            this.textbusqueda.Name = "textbusqueda";
            this.textbusqueda.Size = new System.Drawing.Size(244, 20);
            this.textbusqueda.TabIndex = 20;
            // 
            // MATERIAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 497);
            this.Controls.Add(this.textbusqueda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combobusqueda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TIPO_DE_MATERIAL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbenprocesso);
            this.Controls.Add(this.rbdisponible);
            this.Controls.Add(this.FECHA_RECEP);
            this.Controls.Add(this.comboTIPO_MATERIAL);
            this.Controls.Add(this.textCANTIDADKG);
            this.Controls.Add(this.textIDPERSONAL);
            this.Controls.Add(this.textIDPROVEEDOR);
            this.Controls.Add(this.ELIMINAR);
            this.Controls.Add(this.LIMPIAR);
            this.Controls.Add(this.GUARDAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGBMATERIAL);
            this.Name = "MATERIAL";
            this.Text = "MATERIAL";
            this.Load += new System.EventHandler(this.MATERIAL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGBMATERIAL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGBMATERIAL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GUARDAR;
        private System.Windows.Forms.Button LIMPIAR;
        private System.Windows.Forms.Button ELIMINAR;
        private System.Windows.Forms.TextBox textIDPROVEEDOR;
        private System.Windows.Forms.TextBox textIDPERSONAL;
        private System.Windows.Forms.ComboBox comboTIPO_MATERIAL;
        private System.Windows.Forms.DateTimePicker FECHA_RECEP;
        private System.Windows.Forms.TextBox textCANTIDADKG;
        private System.Windows.Forms.RadioButton rbdisponible;
        private System.Windows.Forms.RadioButton rbenprocesso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TIPO_DE_MATERIAL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combobusqueda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textbusqueda;
    }
}