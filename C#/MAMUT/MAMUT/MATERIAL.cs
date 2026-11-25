using SistemaLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAMUT
{
    public partial class MATERIAL : Form
    {
        public MATERIAL()
        {
            InitializeComponent();
        }
        private void ListarMateriales()
        {
            try
            {
                using (SqlConnection conexion = ConexionBD.Conectar())
                {
                    conexion.Open();
                    string sql = "SELECT * FROM MATERIAL";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        DGBMATERIAL.DataSource = tabla; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ELIMINAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGBMATERIAL.SelectedRows.Count > 0)
                {
                    int idSeleccionado = Convert.ToInt32(DGBMATERIAL.SelectedRows[0].Cells["IdMaterial"].Value);

                    using (SqlConnection conexion = ConexionBD.Conectar())
                    {
                        conexion.Open();
                        string sql = "DELETE FROM MATERIAL WHERE IdMaterial = @id";

                        using (SqlCommand cmd = new SqlCommand(sql, conexion))
                        {
                            cmd.Parameters.AddWithValue("@id", idSeleccionado);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Material eliminado con éxito.");
                    ListarMateriales();
                    LIMPIAR_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Selecciona una fila completa de la tabla para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            textIDPROVEEDOR.Clear();
            textIDPERSONAL.Clear();
            textCANTIDADKG.Clear();
            comboTIPO_MATERIAL.SelectedIndex = -1;
            rbdisponible.Checked = true;
            FECHA_RECEP.Value = DateTime.Now;
        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = ConexionBD.Conectar())
                {
                    conexion.Open();
                    string sql = "INSERT INTO MATERIAL (IdProveedor, IdPersonal, TipoMaterial, Estado, CantidadKg, FechaRecep) VALUES (@idProv, @idPers, @tipo, @estado, @cant, @fecha)";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idProv", int.Parse(textIDPROVEEDOR.Text));
                        cmd.Parameters.AddWithValue("@idPers", int.Parse(textIDPERSONAL.Text));
                        cmd.Parameters.AddWithValue("@tipo", comboTIPO_MATERIAL.Text);
                        cmd.Parameters.AddWithValue("@estado", rbdisponible.Checked ? "Disponible" : "En proceso");
                        cmd.Parameters.AddWithValue("@cant", decimal.Parse(textCANTIDADKG.Text));
                        cmd.Parameters.AddWithValue("@fecha", FECHA_RECEP.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Material guardado con éxito.");
                ListarMateriales();
                LIMPIAR_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void MATERIAL_Load(object sender, EventArgs e)
        {
            ListarMateriales();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rbdisponible_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbenproceso_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TIPO_DE_MATERIAL_Click(object sender, EventArgs e)
        {

        }

        private void DGBMATERIALES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboTIPO_MATERIAL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCONSULTA_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = ConexionBD.Conectar())
                {
                    conexion.Open();
                    string columna = combobusqueda.Text;
                    string sql = $"SELECT * FROM MATERIAL WHERE {columna} LIKE @valor";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@valor", "%" + textbusqueda.Text + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable tabla = new DataTable();
                        adapter.Fill(tabla);
                        DGBMATERIAL.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }
    }
}   
