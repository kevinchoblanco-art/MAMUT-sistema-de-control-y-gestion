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
using System.Data.SqlClient;

namespace MAMUT
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            try
            {
                using (SqlConnection conexion = ConexionBD.Conectar())
                {
                    conexion.Open();
                    if (contadores.sesion_abierta== false)
                    {
                    MessageBox.Show("Conexión exitosa con la base de datos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
            textCLAVE.UseSystemPasswordChar = true;
        }

        private void SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void INGRESAR_Click(object sender, EventArgs e)
        {
            string usuario = textUSUARIO.Text.Trim();
            string clave = textCLAVE.Text;

            if (usuario == "" || clave == "")
            {
                MessageBox.Show("Ingrese usuario y contraseña");
                return;
            }

            try
            {
                using (SqlConnection conexion = ConexionBD.Conectar())
                {
                    conexion.Open();
                    string sql = @"SELECT Nombre, Apellido_Paterno, Apellido_Materno, Cargo, IdPersonal
                                 FROM PERSONAL
                                 WHERE Usuario = @usuario
                                 AND Password = @clave";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.Add("@usuario",System.Data.SqlDbType.VarChar, 30).Value = usuario;
                        cmd.Parameters.Add("@clave",System.Data.SqlDbType.VarChar, 255).Value = clave;
                        int cantidad = 0;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cantidad = 1; // Se encontró el registro
                                contadores.id = reader["IdPersonal"].ToString();
                                contadores.nombre = reader["Nombre"].ToString();
                                contadores.apellido_paterno = reader["Apellido_Paterno"].ToString();
                                contadores.apellido_materno = reader["Apellido_Materno"].ToString();
                                contadores.cargo = reader["Cargo"].ToString();
                                contadores.usuario = usuario;
                            }
                        }
                        if (cantidad > 0)
                        {
                            contadores.sesion_abierta = true;
                            textCLAVE.Clear();
                            textUSUARIO.Focus();
                            this.Hide();
                            MAIN_MENU menu = new MAIN_MENU();
                            menu.ShowDialog();
                            this.Close();
                            
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos");
                            textCLAVE.Clear();
                            textCLAVE.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar: " + ex.Message);
            }
        }

        private void checkCLAVE_CheckedChanged_1(object sender, EventArgs e)
        {
            textCLAVE.UseSystemPasswordChar = !checkCLAVE.Checked;
            if (textCLAVE.UseSystemPasswordChar == true)
            {
                MOST_OCULT.Text = "MOSTRAR CONTRASEÑA";
            }
            else
            {
                MOST_OCULT.Text = "OCULTAR CONTRASEÑA";
            }
        }
    }
}
