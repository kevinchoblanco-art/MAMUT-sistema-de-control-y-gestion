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
            ((System.ComponentModel.ISupportInitialize)(this.MOST_REPORT)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(384, 55);
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
            this.MOST_REPORT.Location = new System.Drawing.Point(55, 246);
            this.MOST_REPORT.Name = "MOST_REPORT";
            this.MOST_REPORT.Size = new System.Drawing.Size(987, 343);
            this.MOST_REPORT.TabIndex = 1;
            // 
            // REPORTAR
            // 
            this.REPORTAR.Location = new System.Drawing.Point(55, 144);
            this.REPORTAR.Name = "REPORTAR";
            this.REPORTAR.Size = new System.Drawing.Size(229, 26);
            this.REPORTAR.TabIndex = 2;
            this.REPORTAR.Text = "REPORTAR";
            this.REPORTAR.UseVisualStyleBackColor = true;
            // 
            // EDITAR
            // 
            this.EDITAR.Location = new System.Drawing.Point(307, 144);
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.Size = new System.Drawing.Size(229, 26);
            this.EDITAR.TabIndex = 3;
            this.EDITAR.Text = "EDITAR REPORTE";
            this.EDITAR.UseVisualStyleBackColor = true;
            // 
            // BORRAR
            // 
            this.BORRAR.Location = new System.Drawing.Point(560, 144);
            this.BORRAR.Name = "BORRAR";
            this.BORRAR.Size = new System.Drawing.Size(229, 26);
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
            "ORDENAR POR CODIGO",
            "SEPARAR POR TIPO"});
            this.ORDENAR_REPO.Location = new System.Drawing.Point(636, 198);
            this.ORDENAR_REPO.Name = "ORDENAR_REPO";
            this.ORDENAR_REPO.Size = new System.Drawing.Size(359, 25);
            this.ORDENAR_REPO.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "ORDENAR POR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 198);
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
            this.TIPO_REPO.Location = new System.Drawing.Point(170, 198);
            this.TIPO_REPO.Name = "TIPO_REPO";
            this.TIPO_REPO.Size = new System.Drawing.Size(325, 25);
            this.TIPO_REPO.TabIndex = 8;
            // 
            // ACTUALISAR
            // 
            this.ACTUALISAR.Location = new System.Drawing.Point(1002, 190);
            this.ACTUALISAR.Name = "ACTUALISAR";
            this.ACTUALISAR.Size = new System.Drawing.Size(40, 40);
            this.ACTUALISAR.TabIndex = 10;
            this.ACTUALISAR.UseVisualStyleBackColor = true;
            this.ACTUALISAR.Click += new System.EventHandler(this.ACTUALISAR_Click);
            // 
            // SALIR
            // 
            this.SALIR.Location = new System.Drawing.Point(813, 144);
            this.SALIR.Name = "SALIR";
            this.SALIR.Size = new System.Drawing.Size(229, 26);
            this.SALIR.TabIndex = 11;
            this.SALIR.Text = "SALIR";
            this.SALIR.UseVisualStyleBackColor = true;
            // 
            // GEST_REPORTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 661);
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
    }
}