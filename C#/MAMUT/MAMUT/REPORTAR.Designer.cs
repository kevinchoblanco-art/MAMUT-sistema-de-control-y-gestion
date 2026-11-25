namespace MAMUT
{
    partial class REPORTAR
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
            this.reporte1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TIPO_REPO = new System.Windows.Forms.ComboBox();
            this.NOMBREREPO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DETALLREPO = new System.Windows.Forms.TextBox();
            this.COD = new System.Windows.Forms.Label();
            this.IDU = new System.Windows.Forms.Label();
            this.USERREPO = new System.Windows.Forms.Label();
            this.FECHAREPO = new System.Windows.Forms.Label();
            this.GUARDARREPO = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUEVO REPORTE";
            // 
            // reporte1
            // 
            this.reporte1.AutoSize = true;
            this.reporte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporte1.Location = new System.Drawing.Point(29, 118);
            this.reporte1.Name = "reporte1";
            this.reporte1.Size = new System.Drawing.Size(139, 13);
            this.reporte1.TabIndex = 1;
            this.reporte1.Text = "CODIGO DE REPORTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID DE USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "USUARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "TIPO DE REPORTE";
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
            this.TIPO_REPO.Location = new System.Drawing.Point(175, 213);
            this.TIPO_REPO.Name = "TIPO_REPO";
            this.TIPO_REPO.Size = new System.Drawing.Size(280, 25);
            this.TIPO_REPO.TabIndex = 9;
            // 
            // NOMBREREPO
            // 
            this.NOMBREREPO.Location = new System.Drawing.Point(175, 270);
            this.NOMBREREPO.Name = "NOMBREREPO";
            this.NOMBREREPO.Size = new System.Drawing.Size(280, 20);
            this.NOMBREREPO.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "NOMBRE DE REPORTE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "DETALLE DE REPORTE";
            // 
            // DETALLREPO
            // 
            this.DETALLREPO.Location = new System.Drawing.Point(176, 330);
            this.DETALLREPO.Multiline = true;
            this.DETALLREPO.Name = "DETALLREPO";
            this.DETALLREPO.Size = new System.Drawing.Size(279, 189);
            this.DETALLREPO.TabIndex = 13;
            // 
            // COD
            // 
            this.COD.AutoSize = true;
            this.COD.Location = new System.Drawing.Point(198, 118);
            this.COD.Name = "COD";
            this.COD.Size = new System.Drawing.Size(25, 13);
            this.COD.TabIndex = 14;
            this.COD.Text = "001";
            // 
            // IDU
            // 
            this.IDU.AutoSize = true;
            this.IDU.Location = new System.Drawing.Point(430, 118);
            this.IDU.Name = "IDU";
            this.IDU.Size = new System.Drawing.Size(25, 13);
            this.IDU.TabIndex = 15;
            this.IDU.Text = "001";
            // 
            // USERREPO
            // 
            this.USERREPO.AutoSize = true;
            this.USERREPO.Location = new System.Drawing.Point(198, 169);
            this.USERREPO.Name = "USERREPO";
            this.USERREPO.Size = new System.Drawing.Size(37, 13);
            this.USERREPO.TabIndex = 16;
            this.USERREPO.Text = "USER";
            // 
            // FECHAREPO
            // 
            this.FECHAREPO.AutoSize = true;
            this.FECHAREPO.Location = new System.Drawing.Point(392, 169);
            this.FECHAREPO.Name = "FECHAREPO";
            this.FECHAREPO.Size = new System.Drawing.Size(61, 13);
            this.FECHAREPO.TabIndex = 17;
            this.FECHAREPO.Text = "2007-01-12";
            // 
            // GUARDARREPO
            // 
            this.GUARDARREPO.BackColor = System.Drawing.SystemColors.Control;
            this.GUARDARREPO.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.GUARDARREPO.FlatAppearance.BorderSize = 2;
            this.GUARDARREPO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GUARDARREPO.Location = new System.Drawing.Point(216, 536);
            this.GUARDARREPO.Name = "GUARDARREPO";
            this.GUARDARREPO.Size = new System.Drawing.Size(237, 43);
            this.GUARDARREPO.TabIndex = 18;
            this.GUARDARREPO.Text = "GUARDAR REPORTE";
            this.GUARDARREPO.UseVisualStyleBackColor = false;
            this.GUARDARREPO.Click += new System.EventHandler(this.GUARDARREPO_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.SystemColors.Control;
            this.salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.salir.FlatAppearance.BorderSize = 2;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.salir.Location = new System.Drawing.Point(12, 536);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(198, 43);
            this.salir.TabIndex = 19;
            this.salir.Text = "SALIR";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // REPORTAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 591);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.GUARDARREPO);
            this.Controls.Add(this.FECHAREPO);
            this.Controls.Add(this.USERREPO);
            this.Controls.Add(this.IDU);
            this.Controls.Add(this.COD);
            this.Controls.Add(this.DETALLREPO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NOMBREREPO);
            this.Controls.Add(this.TIPO_REPO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reporte1);
            this.Controls.Add(this.label1);
            this.Name = "REPORTAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label reporte1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TIPO_REPO;
        private System.Windows.Forms.TextBox NOMBREREPO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DETALLREPO;
        private System.Windows.Forms.Label COD;
        private System.Windows.Forms.Label IDU;
        private System.Windows.Forms.Label USERREPO;
        private System.Windows.Forms.Label FECHAREPO;
        private System.Windows.Forms.Button GUARDARREPO;
        private System.Windows.Forms.Button salir;
    }
}