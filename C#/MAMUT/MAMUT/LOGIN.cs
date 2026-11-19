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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void INGRESAR_Click(object sender, EventArgs e)
        {
            MAIN_MENU menu = new MAIN_MENU();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
