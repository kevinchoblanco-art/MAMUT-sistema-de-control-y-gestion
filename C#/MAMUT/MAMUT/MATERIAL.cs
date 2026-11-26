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
        private void MATERIAL_Load(object sender, EventArgs e)
        {
            ListarMateriales();
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
                    int idSeleccionado = Convert.ToInt32(
                        DGBMATERIAL.SelectedRows[0].Cells["IdMaterial"].Value);

                    DialogResult respuesta = MessageBox.Show("DESEA ELIMINAR EL REGISTRO SELECIONADO ?",
                        "CONFIRMAR ELIMINACION",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                    if(respuesta == DialogResult.No)
                    {
                        return;
                    }



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
            rbdisponible.Checked = false;
            rbenprocesso.Checked = false;
            FECHA_RECEP.Value = DateTime.Now;
        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = ConexionBD.Conectar())
                {
                    conexion.Open();
                    string sql = "INSERT INTO MATERIAL (IdProveedor, IdPersonal, TipoMaterial, Estado, CantidadKg, FechaRecep)"+
                        " VALUES (@idProv, @idPers, @tipo, @estado, @cant, @fecha)";

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
        int selectedRowIndex = -1;
        private void DGBMATERIALES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow columna = DGBMATERIAL.Rows[e.RowIndex];

                textIDPROVEEDOR.Text = columna.Cells["IdProveedor"].Value.ToString();
                textIDPERSONAL.Text = columna.Cells["IdPersonal"].Value.ToString();
                comboTIPO_MATERIAL.Text = columna.Cells["TipoMaterial"].Value.ToString();
                textCANTIDADKG.Text = columna.Cells["CantidadKg"].Value.ToString();
                FECHA_RECEP.Value = Convert.ToDateTime(columna.Cells["FechaRecep"].Value);

                string estado = columna.Cells["Estado"].Value.ToString();
                rbdisponible.Checked = (estado == "Disponible");
                rbenprocesso.Checked = (estado == "En proceso");
                
            }
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

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (DGBMATERIAL.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un material de la tabla para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idMaterial = Convert.ToInt32(DGBMATERIAL.SelectedRows[0].Cells["IdMaterial"].Value);

                using (SqlConnection conexion = ConexionBD.Conectar())
                {
                    conexion.Open();
                    string sql = @"UPDATE MATERIAL 
                           SET IdProveedor = @idProv, 
                               IdPersonal = @idPers, 
                               TipoMaterial = @tipo, 
                               Estado = @estado, 
                               CantidadKg = @cant, 
                               FechaRecep = @fecha 
                           WHERE IdMaterial = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idProv", int.Parse(textIDPROVEEDOR.Text));
                        cmd.Parameters.AddWithValue("@idPers", int.Parse(textIDPERSONAL.Text));
                        cmd.Parameters.AddWithValue("@tipo", comboTIPO_MATERIAL.Text);
                        cmd.Parameters.AddWithValue("@estado", rbdisponible.Checked ? "Disponible" : "En proceso");
                        cmd.Parameters.AddWithValue("@cant", decimal.Parse(textCANTIDADKG.Text));
                        cmd.Parameters.AddWithValue("@fecha", FECHA_RECEP.Value);
                        cmd.Parameters.AddWithValue("@id", idMaterial);

                        int filas = cmd.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show("Material actualizado con éxito.");
                            ListarMateriales();
                            LIMPIAR_Click(sender, e);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }
    }
}   
