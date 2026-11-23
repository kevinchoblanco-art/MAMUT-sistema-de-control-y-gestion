using SistemaLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MAMUT
{
    public partial class GEST_REPORTES : Form
    {
        public GEST_REPORTES()
        {
            InitializeComponent();
            MOSTRAR_LIBROS();
        }
        string TIPO;
        private void MOSTRAR_LIBROS()
        {
            try
            {
                using (SqlConnection conexion = ConexionBD.Conectar())
                {
                    conexion.Open();

                    string sql = "SELECT * FROM REPORTES";

                    SqlDataAdapter adaptador =
                        new SqlDataAdapter(sql, conexion);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    MOST_REPORT.DataSource = tabla;
                    TIPO_REPO.DropDownStyle = ComboBoxStyle.DropDownList;
                    ORDENAR_REPO.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar libros: " + ex.Message);
            }
        }

        private void ACTUALISAR_Click(object sender, EventArgs e)
        {
            if (TIPO_REPO.SelectedItem == null)
            {
                MessageBox.Show("Selecciona A o B.");
                return;
            }

            string opcionElegida = TIPO_REPO.SelectedItem.ToString();

            if (opcionElegida == "REPORTE DE MATERIAL")
            {
                try
                {
                    using (SqlConnection conexion = ConexionBD.Conectar())
                    {
                        conexion.Open();

                        string sqltipo = "select * from REPORTES where Tipo_de_reporte = 'REPORTE DE MATERIAL'";

                        SqlDataAdapter adaptador =
                            new SqlDataAdapter(sqltipo, conexion);

                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        MOST_REPORT.DataSource = tabla;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al listar libros: " + ex.Message);
                }
            }
            else if (opcionElegida == "REPORTE DE LOTE")
            {
                try
                {
                    using (SqlConnection conexion = ConexionBD.Conectar())
                    {
                        conexion.Open();

                        string sqltipo = "select * from REPORTES where Tipo_de_reporte = 'REPORTE DE LOTE'";

                        SqlDataAdapter adaptador =
                            new SqlDataAdapter(sqltipo, conexion);

                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        MOST_REPORT.DataSource = tabla;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al listar libros: " + ex.Message);
                }
            }
            else if (opcionElegida == "REPORTE DE PROVEEDOR")
            {
                try
                {
                    using (SqlConnection conexion = ConexionBD.Conectar())
                    {
                        conexion.Open();

                        string sqltipo = "select * from REPORTES where Tipo_de_reporte = 'REPORTE DE PROVEEDOR'";

                        SqlDataAdapter adaptador =
                            new SqlDataAdapter(sqltipo, conexion);

                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        MOST_REPORT.DataSource = tabla;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al listar libros: " + ex.Message);
                }
            }
            else if (opcionElegida == "REPORTE DE ERROR DE SISTEMA")
            {
                try
                {
                    using (SqlConnection conexion = ConexionBD.Conectar())
                    {
                        conexion.Open();

                        string sqltipo = "select * from REPORTES where Tipo_de_reporte = 'REPORTE DE ERROR DE SISTEMA'";

                        SqlDataAdapter adaptador =
                            new SqlDataAdapter(sqltipo, conexion);

                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        MOST_REPORT.DataSource = tabla;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al listar libros: " + ex.Message);
                }
            }
            else if (opcionElegida == "MOSTRAR TODOS LOS REPORTES")
            {
                try
                {
                    using (SqlConnection conexion = ConexionBD.Conectar())
                    {
                        conexion.Open();

                        string sql = "SELECT * FROM REPORTES";

                        SqlDataAdapter adaptador =
                            new SqlDataAdapter(sql, conexion);

                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        MOST_REPORT.DataSource = tabla;
                        TIPO_REPO.DropDownStyle = ComboBoxStyle.DropDownList;
                        ORDENAR_REPO.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al listar libros: " + ex.Message);
                }
            }
        }
    }
}
