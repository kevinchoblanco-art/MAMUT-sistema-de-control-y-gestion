namespace MAMUT
{
    partial class LOGIN
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUSUARIO = new System.Windows.Forms.TextBox();
            this.textCLAVE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.INGRESAR = new System.Windows.Forms.Button();
            this.SALIR = new System.Windows.Forms.Button();
            this.checkCLAVE = new System.Windows.Forms.CheckBox();
            this.LIMPIAR = new System.Windows.Forms.Button();
            this.MOST_OCULT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE GESTION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "MAMUT";
            // 
            // textUSUARIO
            // 
            this.textUSUARIO.Location = new System.Drawing.Point(205, 192);
            this.textUSUARIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textUSUARIO.Name = "textUSUARIO";
            this.textUSUARIO.Size = new System.Drawing.Size(353, 22);
            this.textUSUARIO.TabIndex = 2;
            this.textUSUARIO.Text = "a";
            // 
            // textCLAVE
            // 
            this.textCLAVE.Location = new System.Drawing.Point(205, 245);
            this.textCLAVE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCLAVE.Name = "textCLAVE";
            this.textCLAVE.Size = new System.Drawing.Size(353, 22);
            this.textCLAVE.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "USUARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "CONTRASEÑA";
            // 
            // INGRESAR
            // 
            this.INGRESAR.Location = new System.Drawing.Point(453, 348);
            this.INGRESAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.INGRESAR.Name = "INGRESAR";
            this.INGRESAR.Size = new System.Drawing.Size(156, 59);
            this.INGRESAR.TabIndex = 6;
            this.INGRESAR.Text = "INGRESAR";
            this.INGRESAR.UseVisualStyleBackColor = true;
            this.INGRESAR.Click += new System.EventHandler(this.INGRESAR_Click);
            // 
            // SALIR
            // 
            this.SALIR.Location = new System.Drawing.Point(163, 348);
            this.SALIR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SALIR.Name = "SALIR";
            this.SALIR.Size = new System.Drawing.Size(156, 59);
            this.SALIR.TabIndex = 7;
            this.SALIR.Text = "SALIR";
            this.SALIR.UseVisualStyleBackColor = true;
            this.SALIR.Click += new System.EventHandler(this.SALIR_Click);
            // 
            // checkCLAVE
            // 
            this.checkCLAVE.AutoSize = true;
            this.checkCLAVE.Location = new System.Drawing.Point(591, 249);
            this.checkCLAVE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkCLAVE.Name = "checkCLAVE";
            this.checkCLAVE.Size = new System.Drawing.Size(18, 17);
            this.checkCLAVE.TabIndex = 8;
            this.checkCLAVE.UseVisualStyleBackColor = true;
            this.checkCLAVE.CheckedChanged += new System.EventHandler(this.checkCLAVE_CheckedChanged_1);
            // 
            // LIMPIAR
            // 
            this.LIMPIAR.Location = new System.Drawing.Point(591, 192);
            this.LIMPIAR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LIMPIAR.Name = "LIMPIAR";
            this.LIMPIAR.Size = new System.Drawing.Size(188, 25);
            this.LIMPIAR.TabIndex = 9;
            this.LIMPIAR.Text = "LIMPIAR";
            this.LIMPIAR.UseVisualStyleBackColor = true;
            // 
            // MOST_OCULT
            // 
            this.MOST_OCULT.AutoSize = true;
            this.MOST_OCULT.Location = new System.Drawing.Point(619, 249);
            this.MOST_OCULT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MOST_OCULT.Name = "MOST_OCULT";
            this.MOST_OCULT.Size = new System.Drawing.Size(172, 16);
            this.MOST_OCULT.TabIndex = 11;
            this.MOST_OCULT.Text = "MOSTRAR CONTRASEÑA";
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 447);
            this.Controls.Add(this.MOST_OCULT);
            this.Controls.Add(this.LIMPIAR);
            this.Controls.Add(this.checkCLAVE);
            this.Controls.Add(this.SALIR);
            this.Controls.Add(this.INGRESAR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCLAVE);
            this.Controls.Add(this.textUSUARIO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LOGIN";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUSUARIO;
        private System.Windows.Forms.TextBox textCLAVE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button INGRESAR;
        private System.Windows.Forms.Button SALIR;
        private System.Windows.Forms.CheckBox checkCLAVE;
        private System.Windows.Forms.Button LIMPIAR;
        private System.Windows.Forms.Label MOST_OCULT;
    }
}

