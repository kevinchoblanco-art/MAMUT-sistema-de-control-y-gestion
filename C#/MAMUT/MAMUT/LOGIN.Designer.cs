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
            this.MOST_OCULT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE GESTION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "MAMUT";
            // 
            // textUSUARIO
            // 
            this.textUSUARIO.Location = new System.Drawing.Point(154, 156);
            this.textUSUARIO.Name = "textUSUARIO";
            this.textUSUARIO.Size = new System.Drawing.Size(266, 20);
            this.textUSUARIO.TabIndex = 2;
            // 
            // textCLAVE
            // 
            this.textCLAVE.Location = new System.Drawing.Point(154, 199);
            this.textCLAVE.Name = "textCLAVE";
            this.textCLAVE.Size = new System.Drawing.Size(266, 20);
            this.textCLAVE.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "USUARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CONTRASEÑA";
            // 
            // INGRESAR
            // 
            this.INGRESAR.Location = new System.Drawing.Point(340, 283);
            this.INGRESAR.Name = "INGRESAR";
            this.INGRESAR.Size = new System.Drawing.Size(117, 48);
            this.INGRESAR.TabIndex = 6;
            this.INGRESAR.Text = "INGRESAR";
            this.INGRESAR.UseVisualStyleBackColor = true;
            this.INGRESAR.Click += new System.EventHandler(this.INGRESAR_Click);
            // 
            // SALIR
            // 
            this.SALIR.Location = new System.Drawing.Point(122, 283);
            this.SALIR.Name = "SALIR";
            this.SALIR.Size = new System.Drawing.Size(117, 48);
            this.SALIR.TabIndex = 7;
            this.SALIR.Text = "SALIR";
            this.SALIR.UseVisualStyleBackColor = true;
            this.SALIR.Click += new System.EventHandler(this.SALIR_Click);
            // 
            // checkCLAVE
            // 
            this.checkCLAVE.AutoSize = true;
            this.checkCLAVE.Location = new System.Drawing.Point(443, 202);
            this.checkCLAVE.Name = "checkCLAVE";
            this.checkCLAVE.Size = new System.Drawing.Size(15, 14);
            this.checkCLAVE.TabIndex = 8;
            this.checkCLAVE.UseVisualStyleBackColor = true;
            this.checkCLAVE.CheckedChanged += new System.EventHandler(this.checkCLAVE_CheckedChanged_1);
            // 
            // LIMPIAR
            // 
            this.LIMPIAR.Location = new System.Drawing.Point(443, 156);
            this.LIMPIAR.Name = "LIMPIAR";
            this.LIMPIAR.Size = new System.Drawing.Size(141, 20);
            this.LIMPIAR.TabIndex = 9;
            this.LIMPIAR.Text = "LIMPIAR";
            this.LIMPIAR.UseVisualStyleBackColor = true;
            // 
            // MOST_OCULT
            // 
            this.MOST_OCULT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MOST_OCULT.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MOST_OCULT.ForeColor = System.Drawing.Color.Black;
            this.MOST_OCULT.Location = new System.Drawing.Point(464, 203);
            this.MOST_OCULT.Name = "MOST_OCULT";
            this.MOST_OCULT.Size = new System.Drawing.Size(148, 13);
            this.MOST_OCULT.TabIndex = 10;
            this.MOST_OCULT.Text = "MOSTRAR CONTRASEÑA";
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 363);
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
        private System.Windows.Forms.TextBox MOST_OCULT;
    }
}

