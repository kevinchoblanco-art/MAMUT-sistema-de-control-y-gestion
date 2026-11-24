using SistemaLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAMUT
{
    public partial class MAIN_MENU : Form
    {
        public MAIN_MENU()
        {
            InitializeComponent();
            ID.Text = contadores.id;
            usuario.Text = contadores.usuario;
            nombre.Text = contadores.nombre;
            apellidoP.Text = contadores.apellido_paterno;
            apellidoM.Text = contadores.apellido_materno;
            cargo.Text = contadores.cargo;
        }

        private void cERRARSESIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMATERIAL_Click(object sender, EventArgs e)
        {
            MATERIAL material = new MATERIAL();
            material.ShowDialog();
        }

        private void btnLOTES_CAUCHO_Click(object sender, EventArgs e)
        {
            LOTES_DE_CAUCHO lotes = new LOTES_DE_CAUCHO();
            lotes.ShowDialog();
        }

        private void btnMOVIMIENTOS_Click(object sender, EventArgs e)
        {
            MOVIMIENTOS material = new MOVIMIENTOS();
            material.ShowDialog();
        }

        private void btnUSUARIOS_Click(object sender, EventArgs e)
        {
            FrmUsuario1 usuarios = new FrmUsuario1();
            usuarios.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nombre_Click(object sender, EventArgs e)
        {

        }

        private void gESTIONDEREPORTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GEST_REPORTES gest_reportes = new GEST_REPORTES();
            gest_reportes.ShowDialog();
        }
    }
}
