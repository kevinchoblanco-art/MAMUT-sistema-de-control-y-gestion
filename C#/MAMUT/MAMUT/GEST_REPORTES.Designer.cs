namespace MAMUT
{
    partial class GEST_REPORTES
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
            this.label1 = new System.Windows.Forms.Label();
            this.MOST_REPORT = new System.Windows.Forms.DataGridView();
            this.REPORTAR = new System.Windows.Forms.Button();
            this.EDITAR = new System.Windows.Forms.Button();
            this.BORRAR = new System.Windows.Forms.Button();
            this.ORDENAR_REPO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TIPO_REPO = new System.Windows.Forms.ComboBox();
            this.ACTUALISAR = new System.Windows.Forms.Button();
            this.SALIR = new System.Windows.Forms.Button();
            this.BUSCAR_POR = new System.Windows.Forms.Button();
            this.BUSCAR = new System.Windows.Forms.Button();
            this.DATO_DE_BUSQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TIPO_DE_BUSQUEDA = new System.Windows.Forms.ComboBox();
            this.CODIGO_DE_EDIT = new System.Windows.Forms.TextBox();
            this.NOMBRE_DE_EDIT = new System.Windows.Forms.TextBox();
            this.DETALLE_DE_EDIT = new System.Windows.Forms.TextBox();
            this.actalisarReporte = new System.Windows.Forms.Button();
            this.edit1 = new System.Windows.Forms.Label();
            this.edit2 = new System.Windows.Forms.Label();
            this.edit3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MOST_REPORT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(381, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION DE REPORTES";
            // 
            // MOST_REPORT
            // 
            this.MOST_REPORT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MOST_REPORT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MOST_REPORT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MOST_REPORT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MOST_REPORT.Location = new System.Drawing.Point(55, 274);
            this.MOST_REPORT.Name = "MOST_REPORT";
            this.MOST_REPORT.Size = new System.Drawing.Size(987, 343);
            this.MOST_REPORT.TabIndex = 1;
            // 
            // REPORTAR
            // 
            this.REPORTAR.Location = new System.Drawing.Point(55, 108);
            this.REPORTAR.Name = "REPORTAR";
            this.REPORTAR.Size = new System.Drawing.Size(180, 26);
            this.REPORTAR.TabIndex = 2;
            this.REPORTAR.Text = "REPORTAR";
            this.REPORTAR.UseVisualStyleBackColor = true;
            // 
            // EDITAR
            // 
            this.EDITAR.Location = new System.Drawing.Point(257, 108);
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.Size = new System.Drawing.Size(180, 26);
            this.EDITAR.TabIndex = 3;
            this.EDITAR.Text = "EDITAR REPORTE";
            this.EDITAR.UseVisualStyleBackColor = true;
            this.EDITAR.Click += new System.EventHandler(this.EDITAR_Click);
            // 
            // BORRAR
            // 
            this.BORRAR.Location = new System.Drawing.Point(465, 108);
            this.BORRAR.Name = "BORRAR";
            this.BORRAR.Size = new System.Drawing.Size(180, 26);
            this.BORRAR.TabIndex = 5;
            this.BORRAR.Text = "BORRAR REPORTE";
            this.BORRAR.UseVisualStyleBackColor = true;
            // 
            // ORDENAR_REPO
            // 
            this.ORDENAR_REPO.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORDENAR_REPO.FormattingEnabled = true;
            this.ORDENAR_REPO.Items.AddRange(new object[] {
            "MAS RECIENTE PRIMERO",
            "MAS ANTIGUO PRIMERO",
            "POR CODIGO ACENDENTE",
            "POR CODIGO DESENDENTE"});
            this.ORDENAR_REPO.Location = new System.Drawing.Point(634, 222);
            this.ORDENAR_REPO.Name = "ORDENAR_REPO";
            this.ORDENAR_REPO.Size = new System.Drawing.Size(359, 25);
            this.ORDENAR_REPO.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "ORDENAR POR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "TIPO DE REPORTE";
            // 
            // TIPO_REPO
            // 
            this.TIPO_REPO.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIPO_REPO.FormattingEnabled = true;
            this.TIPO_REPO.Items.AddRange(new object[] {
            "MOSTRAR TODOS LOS REPORTES",
            "REPORTE DE MATERIAL",
            "REPORTE DE LOTE",
            "REPORTE DE PROVEEDOR",
            "REPORTE DE ERROR DE SISTEMA"});
            this.TIPO_REPO.Location = new System.Drawing.Point(168, 222);
            this.TIPO_REPO.Name = "TIPO_REPO";
            this.TIPO_REPO.Size = new System.Drawing.Size(325, 25);
            this.TIPO_REPO.TabIndex = 8;
            // 
            // ACTUALISAR
            // 
            this.ACTUALISAR.Location = new System.Drawing.Point(1000, 214);
            this.ACTUALISAR.Name = "ACTUALISAR";
            this.ACTUALISAR.Size = new System.Drawing.Size(40, 40);
            this.ACTUALISAR.TabIndex = 10;
            this.ACTUALISAR.UseVisualStyleBackColor = true;
            this.ACTUALISAR.Click += new System.EventHandler(this.ACTUALISAR_Click);
            // 
            // SALIR
            // 
            this.SALIR.Location = new System.Drawing.Point(862, 108);
            this.SALIR.Name = "SALIR";
            this.SALIR.Size = new System.Drawing.Size(180, 26);
            this.SALIR.TabIndex = 11;
            this.SALIR.Text = "SALIR";
            this.SALIR.UseVisualStyleBackColor = true;
            this.SALIR.Click += new System.EventHandler(this.SALIR_Click);
            // 
            // BUSCAR_POR
            // 
            this.BUSCAR_POR.Location = new System.Drawing.Point(666, 108);
            this.BUSCAR_POR.Name = "BUSCAR_POR";
            this.BUSCAR_POR.Size = new System.Drawing.Size(180, 26);
            this.BUSCAR_POR.TabIndex = 12;
            this.BUSCAR_POR.Text = "BUSCAR POR ......";
            this.BUSCAR_POR.UseVisualStyleBackColor = true;
            this.BUSCAR_POR.Click += new System.EventHandler(this.BUSCAR_POR_Click);
            // 
            // BUSCAR
            // 
            this.BUSCAR.Location = new System.Drawing.Point(860, 180);
            this.BUSCAR.Name = "BUSCAR";
            this.BUSCAR.Size = new System.Drawing.Size(180, 26);
            this.BUSCAR.TabIndex = 14;
            this.BUSCAR.Text = "BUSCAR";
            this.BUSCAR.UseVisualStyleBackColor = true;
            this.BUSCAR.Click += new System.EventHandler(this.BUSCAR_Click);
            // 
            // DATO_DE_BUSQ
            // 
            this.DATO_DE_BUSQ.Location = new System.Drawing.Point(531, 184);
            this.DATO_DE_BUSQ.Name = "DATO_DE_BUSQ";
            this.DATO_DE_BUSQ.Size = new System.Drawing.Size(314, 20);
            this.DATO_DE_BUSQ.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "BUSCAR POR :";
            // 
            // TIPO_DE_BUSQUEDA
            // 
            this.TIPO_DE_BUSQUEDA.FormattingEnabled = true;
            this.TIPO_DE_BUSQUEDA.Items.AddRange(new object[] {
            "CODIGO",
            "NOMBRE DE REPORTE",
            "USUARIO"});
            this.TIPO_DE_BUSQUEDA.Location = new System.Drawing.Point(168, 184);
            this.TIPO_DE_BUSQUEDA.Name = "TIPO_DE_BUSQUEDA";
            this.TIPO_DE_BUSQUEDA.Size = new System.Drawing.Size(226, 21);
            this.TIPO_DE_BUSQUEDA.TabIndex = 13;
            // 
            // CODIGO_DE_EDIT
            // 
            this.CODIGO_DE_EDIT.Location = new System.Drawing.Point(53, 182);
            this.CODIGO_DE_EDIT.Name = "CODIGO_DE_EDIT";
            this.CODIGO_DE_EDIT.Size = new System.Drawing.Size(179, 20);
            this.CODIGO_DE_EDIT.TabIndex = 19;
            this.CODIGO_DE_EDIT.Visible = false;
            // 
            // NOMBRE_DE_EDIT
            // 
            this.NOMBRE_DE_EDIT.Location = new System.Drawing.Point(257, 182);
            this.NOMBRE_DE_EDIT.Name = "NOMBRE_DE_EDIT";
            this.NOMBRE_DE_EDIT.Size = new System.Drawing.Size(180, 20);
            this.NOMBRE_DE_EDIT.TabIndex = 20;
            this.NOMBRE_DE_EDIT.Visible = false;
            // 
            // DETALLE_DE_EDIT
            // 
            this.DETALLE_DE_EDIT.Location = new System.Drawing.Point(465, 182);
            this.DETALLE_DE_EDIT.Name = "DETALLE_DE_EDIT";
            this.DETALLE_DE_EDIT.Size = new System.Drawing.Size(381, 20);
            this.DETALLE_DE_EDIT.TabIndex = 21;
            this.DETALLE_DE_EDIT.Visible = false;
            // 
            // actalisarReporte
            // 
            this.actalisarReporte.Location = new System.Drawing.Point(852, 178);
            this.actalisarReporte.Name = "actalisarReporte";
            this.actalisarReporte.Size = new System.Drawing.Size(180, 26);
            this.actalisarReporte.TabIndex = 22;
            this.actalisarReporte.Text = "ACTUALIZAR";
            this.actalisarReporte.UseVisualStyleBackColor = true;
            this.actalisarReporte.Visible = false;
            this.actalisarReporte.Click += new System.EventHandler(this.actalisarReporte_Click);
            // 
            // edit1
            // 
            this.edit1.AutoSize = true;
            this.edit1.Location = new System.Drawing.Point(78, 166);
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(128, 13);
            this.edit1.TabIndex = 23;
            this.edit1.Text = "CODIGO DEL REPORTE";
            this.edit1.Visible = false;
            // 
            // edit2
            // 
            this.edit2.AutoSize = true;
            this.edit2.Location = new System.Drawing.Point(282, 166);
            this.edit2.Name = "edit2";
            this.edit2.Size = new System.Drawing.Size(127, 13);
            this.edit2.TabIndex = 24;
            this.edit2.Text = "NOMBRE DE REPORTE";
            this.edit2.Visible = false;
            // 
            // edit3
            // 
            this.edit3.AutoSize = true;
            this.edit3.Location = new System.Drawing.Point(593, 166);
            this.edit3.Name = "edit3";
            this.edit3.Size = new System.Drawing.Size(134, 13);
            this.edit3.TabIndex = 25;
            this.edit3.Text = "DETALLE DEL REPORTE";
            this.edit3.Visible = false;
            // 
            // GEST_REPORTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 661);
            this.Controls.Add(this.edit3);
            this.Controls.Add(this.edit2);
            this.Controls.Add(this.edit1);
            this.Controls.Add(this.actalisarReporte);
            this.Controls.Add(this.DETALLE_DE_EDIT);
            this.Controls.Add(this.NOMBRE_DE_EDIT);
            this.Controls.Add(this.CODIGO_DE_EDIT);
            this.Controls.Add(this.DATO_DE_BUSQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BUSCAR);
            this.Controls.Add(this.TIPO_DE_BUSQUEDA);
            this.Controls.Add(this.BUSCAR_POR);
            this.Controls.Add(this.SALIR);
            this.Controls.Add(this.ACTUALISAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TIPO_REPO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ORDENAR_REPO);
            this.Controls.Add(this.BORRAR);
            this.Controls.Add(this.EDITAR);
            this.Controls.Add(this.REPORTAR);
            this.Controls.Add(this.MOST_REPORT);
            this.Controls.Add(this.label1);
            this.Name = "GEST_REPORTES";
            this.Text = "GEST_REPORTES";
            ((System.ComponentModel.ISupportInitialize)(this.MOST_REPORT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MOST_REPORT;
        private System.Windows.Forms.Button REPORTAR;
        private System.Windows.Forms.Button EDITAR;
        private System.Windows.Forms.Button BORRAR;
        private System.Windows.Forms.ComboBox ORDENAR_REPO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TIPO_REPO;
        private System.Windows.Forms.Button ACTUALISAR;
        private System.Windows.Forms.Button SALIR;
        private System.Windows.Forms.Button BUSCAR_POR;
        private System.Windows.Forms.Button BUSCAR;
        private System.Windows.Forms.TextBox DATO_DE_BUSQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TIPO_DE_BUSQUEDA;
        private System.Windows.Forms.TextBox CODIGO_DE_EDIT;
        private System.Windows.Forms.TextBox NOMBRE_DE_EDIT;
        private System.Windows.Forms.TextBox DETALLE_DE_EDIT;
        private System.Windows.Forms.Button actalisarReporte;
        private System.Windows.Forms.Label edit1;
        private System.Windows.Forms.Label edit2;
        private System.Windows.Forms.Label edit3;
    }
}