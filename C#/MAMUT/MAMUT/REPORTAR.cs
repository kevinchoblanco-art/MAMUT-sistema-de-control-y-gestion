using SistemaLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MAMUT
{
    public partial class REPORTAR : Form
    {
        public REPORTAR()
        {
            InitializeComponent();
            guardar_ultimos_codigos();
            COD.Text = contadores.ultimoreporte.ToString();
            IDU.Text = contadores.id;
            USERREPO.Text = contadores.usuario;
            FECHAREPO.Text = contadores.fecha;
            TIPO_REPO.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void guardar_ultimos_codigos()
        {
            using (SqlConnection conexion = ConexionBD.Conectar())
            {
                conexion.Open();

                string sqlcodnewrepo = "SELECT ISNULL(MAX(COD_reporte), 0) + 1 AS SiguienteCodigo FROM REPORTES;";

                using (SqlCommand cmd = new SqlCommand(sqlcodnewrepo, conexion))
                {
                    object resultado = cmd.ExecuteScalar();
                    int newcodrepo = (resultado != null && resultado != DBNull.Value)
                        ? Convert.ToInt32(resultado)
                        : 1;

                    contadores.ultimoreporte = newcodrepo;
                }
            }
        }

        private void GUARDARREPO_Click(object sender, EventArgs e)
        {
            string tipo = TIPO_REPO.SelectedItem?.ToString() ?? string.Empty;
            int id   = int.Parse(contadores.id);
            string usuario = contadores.usuario;
            string fechas = contadores.fecha;
            string nombre = NOMBREREPO.Text;
            string detalle = DETALLREPO.Text;
            try
            {
                using (SqlConnection conexion = ConexionBD.Conectar())
                {
                    conexion.Open();

                    string sqlnewreport = "INSERT INTO REPORTES  (IdPersonal, usuario, Tipo_de_reporte, nombre_de_reporte, detalle_de_reporte, Fecha) VALUES (@id, @usuario, @tipo, @nombre, @detalle, @fechas)";

                    using (SqlCommand cmd = new SqlCommand(sqlnewreport, conexion))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 30).Value = usuario;
                        cmd.Parameters.Add("@tipo", SqlDbType.VarChar, 30).Value = tipo;
                        cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = nombre;
                        cmd.Parameters.Add("@detalle", SqlDbType.VarChar, 500).Value = detalle;
                        cmd.Parameters.Add("@fechas", SqlDbType.Date).Value = fechas;
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Reeporte generado exitosamente");
                        }
                        else
                        {
                            MessageBox.Show("hubo algun error al generar el reporte");
                        }
                        TIPO_REPO.SelectedIndex = -1;
                        NOMBREREPO.Clear();
                        DETALLREPO.Clear();
                        NOMBREREPO.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar reportes: " + ex.Message);
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
