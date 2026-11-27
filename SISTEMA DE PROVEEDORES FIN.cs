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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaProveedores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CargarProveedores()
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = "SELECT * FROM PROVEEDOR";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int? ObtenerIdSeleccionado()
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Selecciona primero un proveedor en la tabla.");
                return null;
            }

            object valorId = dataGridView1.CurrentRow.Cells["IdProveedor"].Value;
            if (valorId == null || !int.TryParse(valorId.ToString(), out int idProveedor))
            {
                MessageBox.Show("No se pudo obtener un IdProveedor válido de la fila seleccionada.");
                return null;
            }

            return idProveedor;
        }
        private void LimpiarCampos()
        {
            textnombre.Clear();
            textdireccion.Clear();
            texttelefono.Clear();
            texttipo.Clear();

            if (textId.Items.Count > 0)
            {
                textId.SelectedIndex = 0;
            }

            textnombre.Focus();
        }
        private void AGREGAR_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = "INSERT INTO PROVEEDOR (Nombre, Direccion, Telefono, TipoProv) VALUES (@nombre, @direccion, @telefono, @tipo)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", textnombre.Text);
                    cmd.Parameters.AddWithValue("@direccion", textdireccion.Text);
                    cmd.Parameters.AddWithValue("@telefono", texttelefono.Text);
                    cmd.Parameters.AddWithValue("@tipo", texttipo.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Proveedor agregado correctamente.");
                    CargarProveedores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        private void MODIFICAR_Click(object sender, EventArgs e)
        {
            int? idProveedor = ObtenerIdSeleccionado();
            if (idProveedor == null) return;

            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = "UPDATE PROVEEDOR SET Nombre=@nombre, Direccion=@direccion, Telefono=@telefono, TipoProv=@tipo WHERE IdProveedor=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", idProveedor.Value);
                    cmd.Parameters.AddWithValue("@nombre", textnombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@direccion", textdireccion.Text.Trim());
                    cmd.Parameters.AddWithValue("@telefono", texttelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@tipo", texttipo.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Proveedor actualizado correctamente.");
                    CargarProveedores();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

      
        private void ELIMINAR_Click(object sender, EventArgs e)
        {
            int? idProveedor = ObtenerIdSeleccionado();
            if (idProveedor == null) return;

            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string query = "DELETE FROM PROVEEDOR WHERE IdProveedor=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", idProveedor.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Proveedor eliminado correctamente.");
                    CargarProveedores();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void CONSULTAR_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string filtro = textnombre.Text.Trim();
                    string query;
                    SqlCommand cmd;

                    if (string.IsNullOrEmpty(filtro))
                    {
                        query = "SELECT * FROM PROVEEDOR";
                        cmd = new SqlCommand(query, con);
                    }
                    else
                    {
                        query = "SELECT * FROM PROVEEDOR WHERE Nombre LIKE @filtro";
                        cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = Conexion.ObtenerConexion())
                {
                    string tipoSeleccionado = textId.SelectedItem?.ToString();
                    SqlCommand cmd;

                    if (string.IsNullOrEmpty(tipoSeleccionado) || tipoSeleccionado == "Todos")
                    {
                        cmd = new SqlCommand("SELECT * FROM PROVEEDOR", con);
                    }
                    else
                    {
                        cmd = new SqlCommand("SELECT * FROM PROVEEDOR WHERE TipoProv = @tipo", con);
                        cmd.Parameters.AddWithValue("@tipo", tipoSeleccionado);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textId.DropDownStyle = ComboBoxStyle.DropDownList;
            textId.Items.Clear();
            textId.Items.Add("Todos");
            textId.Items.Add("Mecánico");
            textId.Items.Add("Llantería");
            textId.SelectedIndex = 0;

            CargarProveedores();
        }

        private void LIMPIAR_Click(object sender, EventArgs e)
        {
            {
                textnombre.Clear();
                textdireccion.Clear();
                texttelefono.Clear();
                texttipo.Clear();

                if (textId.Items.Count > 0)
                {
                    textId.SelectedIndex = 0;
                }

                textnombre.Focus();
            }
        }
    }
}
    
