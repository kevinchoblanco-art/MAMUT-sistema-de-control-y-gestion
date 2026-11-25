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
                    TIPO_DE_BUSQUEDA.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar libros: " + ex.Message);
            }
        }

        private void ACTUALISAR_Click(object sender, EventArgs e)
        {
            if (TIPO_REPO.SelectedItem == null && ORDENAR_REPO.SelectedItem == null)
            {
                MessageBox.Show("Selecciona el tipo o el orden");
                return;
            }
            if (TIPO_REPO.SelectedItem != null)
            {
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
            
            if (ORDENAR_REPO.SelectedItem != null) 
            {
                string ordenar = ORDENAR_REPO.SelectedItem.ToString();
                if (ordenar == "MAS RECIENTE PRIMERO")
                {
                    try
                    {
                        using (SqlConnection conexion = ConexionBD.Conectar())
                        {
                            conexion.Open();

                            string sqltipo = "SELECT * FROM REPORTES ORDER BY Fecha desc";

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
                else if (ordenar == "MAS ANTIGUO PRIMERO")
                {
                    try
                    {
                        using (SqlConnection conexion = ConexionBD.Conectar())
                        {
                            conexion.Open();

                            string sqltipo = "SELECT * FROM REPORTES ORDER BY Fecha asc";

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
                else if (ordenar == "POR CODIGO ACENDENTE")
                {
                    try
                    {
                        using (SqlConnection conexion = ConexionBD.Conectar())
                        {
                            conexion.Open();

                            string sqltipo = "SELECT * FROM REPORTES ORDER BY COD_reporte asc";

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
                else if (ordenar == "POR CODIGO DESENDENTE")
                {
                    try
                    {
                        using (SqlConnection conexion = ConexionBD.Conectar())
                        {
                            conexion.Open();

                            string sql = "SELECT * FROM REPORTES ORDER BY COD_reporte desc";

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
            
            //ordnera por... /  /  / POR CODIGO DESENDENTE
            
            TIPO_REPO.SelectedIndex = -1;
            ORDENAR_REPO.SelectedIndex = -1;
        }


        private void EDITAR_Click(object sender, EventArgs e)
        {
            CODIGO_DE_EDIT.Focus();
            NOMBRE_DE_EDIT.Clear();
            DETALLE_DE_EDIT.Clear();
            edit1.Visible = true;
            edit2.Visible = true;
            edit3.Visible = true;
            actalisarReporte.Visible = true;
            CODIGO_DE_EDIT.Visible = true;
            NOMBRE_DE_EDIT.Visible = true;
            DETALLE_DE_EDIT.Visible = true;
            label4.Visible = false;
            TIPO_DE_BUSQUEDA.Visible = false;
            DATO_DE_BUSQ.Visible = false;
            BUSCAR.Visible = false;
            BORRAR_COD_REPO.Visible = false;
            BORRAR_REPO.Visible = false;
            borrar1.Visible = false;
        }

        private void SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUSCAR_Click(object sender, EventArgs e)
        {
            if (TIPO_DE_BUSQUEDA.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un tipo de búsqueda.");
                return;
            }

            string opciondebusqueda = TIPO_DE_BUSQUEDA.SelectedItem.ToString();

            if (opciondebusqueda == "CODIGO")
            {
                if (!int.TryParse(DATO_DE_BUSQ.Text.Trim(), out int codigodebusq))
                {
                    MessageBox.Show("Ingresa un código numérico válido.");
                    return;
                }

                try
                {
                    using (SqlConnection conexion = ConexionBD.Conectar())
                    {
                        conexion.Open();

                        string sqltipo = "SELECT * FROM REPORTES WHERE COD_reporte = @codigodebusq;";

                        using (SqlCommand cmd = new SqlCommand(sqltipo, conexion))
                        {
                            cmd.Parameters.Add("@codigodebusq", SqlDbType.Int).Value = codigodebusq;

                            using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                            {
                                DataTable tabla = new DataTable();
                                adaptador.Fill(tabla);

                                if (tabla.Rows.Count == 0)
                                {
                                    MessageBox.Show("No se encontró ningún reporte con ese código.");
                                }

                                MOST_REPORT.DataSource = tabla;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar reportes: " + ex.Message);
                }
            }
            else if (opciondebusqueda == "NOMBRE DE REPORTE")
            {
                string codigodebusq = DATO_DE_BUSQ.Text.ToString();
                try
                {
                    using (SqlConnection conexion = ConexionBD.Conectar())
                    {
                        conexion.Open();

                        string sqltipo = "SELECT * FROM REPORTES WHERE nombre_de_reporte = @codigodebusq;";

                        using (SqlCommand cmd = new SqlCommand(sqltipo, conexion))
                        {
                            cmd.Parameters.Add("@codigodebusq", SqlDbType.VarChar, 30).Value = codigodebusq;

                            using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                            {
                                DataTable tabla = new DataTable();
                                adaptador.Fill(tabla);

                                if (tabla.Rows.Count == 0)
                                {
                                    MessageBox.Show("No se encontró ningún reporte con ese código.");
                                }

                                MOST_REPORT.DataSource = tabla;
                            }
                        }
                    }
                    DATO_DE_BUSQ.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar reportes: " + ex.Message);
                }
            }
            else if (opciondebusqueda == "USUARIO")
            {
                string codigodebusq = DATO_DE_BUSQ.Text.ToString();

                try
                {
                    using (SqlConnection conexion = ConexionBD.Conectar())
                    {
                        conexion.Open();

                        string sqltipo = "SELECT * FROM REPORTES WHERE usuario = @codigodebusq;";

                        using (SqlCommand cmd = new SqlCommand(sqltipo, conexion))
                        {
                            cmd.Parameters.Add("@codigodebusq", SqlDbType.VarChar, 30).Value = codigodebusq;

                            using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                            {
                                DataTable tabla = new DataTable();
                                adaptador.Fill(tabla);

                                if (tabla.Rows.Count == 0)
                                {
                                    MessageBox.Show("No se encontró ningún reporte con ese código.");
                                }

                                MOST_REPORT.DataSource = tabla;
                            }
                        }
                    }
                    DATO_DE_BUSQ.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar reportes: " + ex.Message);
                }
            }
            TIPO_DE_BUSQUEDA.SelectedIndex = -1;
            DATO_DE_BUSQ.Clear();
            DATO_DE_BUSQ.Focus();
        }

        private void actalisarReporte_Click(object sender, EventArgs e)
        {
            string codigoedit = CODIGO_DE_EDIT.Text.ToString();
            string nombreedit = NOMBRE_DE_EDIT.Text.ToString();
            string detalledit = DETALLE_DE_EDIT.Text.ToString();

            if (contadores.admin_activo == true)
            {
                if (!int.TryParse(CODIGO_DE_EDIT.Text.Trim(), out int codigodebusq))
                {
                    MessageBox.Show("Ingresa un código numérico válido.");
                    return;
                }
                try
                {
                    using (SqlConnection conexion = ConexionBD.Conectar())
                    {
                        conexion.Open();

                        string sqledit = "UPDATE REPORTES SET nombre_de_reporte = @nombreedit, detalle_de_reporte = @detalledit where COD_reporte = @codigoedit;";

                        using (SqlCommand cmd = new SqlCommand(sqledit, conexion))
                        {
                            cmd.Parameters.Add("@codigoedit", SqlDbType.VarChar, 30).Value = codigoedit;
                            cmd.Parameters.Add("@nombreedit", SqlDbType.VarChar, 200).Value = nombreedit;
                            cmd.Parameters.Add("@detalledit", SqlDbType.VarChar, 30).Value = detalledit;
                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Reporte actualizado correctamente.");
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningún reporte con ese código.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar reportes: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("SOLO EL ADMINISTRADOR PUEDE EDITAR REPORTES");
                CODIGO_DE_EDIT.Clear();
                NOMBRE_DE_EDIT.Clear();
                DETALLE_DE_EDIT.Clear();
            }
        }

        private void BUSCAR_POR_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            TIPO_DE_BUSQUEDA.Visible = true;
            DATO_DE_BUSQ.Visible = true;
            BUSCAR.Visible = true;
            CODIGO_DE_EDIT.Visible = false;
            NOMBRE_DE_EDIT.Visible = false;
            DETALLE_DE_EDIT.Visible = false;
            edit1.Visible = false;
            edit2.Visible = false;
            edit3.Visible = false;
            actalisarReporte.Visible = false;
            BORRAR_COD_REPO.Visible = false;
            BORRAR_REPO.Visible = false;
            borrar1.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BORRAR_REPO_Click(object sender, EventArgs e)
        {
            int codborrar = int.Parse(BORRAR_COD_REPO.Text);
            if (contadores.admin_activo == true)
            {
                try
                {
                    using (SqlConnection conexion = ConexionBD.Conectar())
                    {
                        conexion.Open();

                        string sqlborrar = "DELETE  FROM REPORTES WHERE COD_reporte = @codborrar";

                        using (SqlCommand cmd = new SqlCommand(sqlborrar, conexion))
                        {
                            cmd.Parameters.Add("@codborrar", SqlDbType.Int).Value = codborrar;

                            using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                            {
                                DataTable tabla = new DataTable();
                                adaptador.Fill(tabla);

                                if (tabla.Rows.Count == 0)
                                {
                                    MessageBox.Show("No se encontró ningún reporte con ese código.");
                                }

                                MOST_REPORT.DataSource = tabla;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar reportes: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("SOLO EL ADMINISTRADOR PUEDE BORRAR LOS REPORTES");
            }
            
        }

        private void BORRAR_Click(object sender, EventArgs e)
        {
            BORRAR_COD_REPO.Visible = true;
            BORRAR_REPO.Visible = true;
            borrar1.Visible = true;
            CODIGO_DE_EDIT.Visible = false;
            NOMBRE_DE_EDIT.Visible = false;
            DETALLE_DE_EDIT.Visible = false;
            edit1.Visible = false;
            edit2.Visible = false;
            edit3.Visible = false;
            actalisarReporte.Visible = false;
            label4.Visible = false;
            TIPO_DE_BUSQUEDA.Visible = false;
            DATO_DE_BUSQ.Visible = false;
            BUSCAR.Visible = false;
        }

        private void REPORTAR1_Click(object sender, EventArgs e)
        {
            REPORTAR report = new REPORTAR();
            report.ShowDialog();
        }
    }
}

