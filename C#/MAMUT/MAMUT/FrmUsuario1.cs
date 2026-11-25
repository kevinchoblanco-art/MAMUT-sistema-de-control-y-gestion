using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaLogin;

namespace MAMUT
{
    public partial class FrmUsuario1 : Form
    {
        public FrmUsuario1()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        // CARGAR DATOS EN LA TABLA (READ)
        private void CargarUsuarios()
        {
            try
            {
                using (SqlConnection con = ConexionBD.Conectar())
                {
                    con.Open();
                    string query = "SELECT IdPersonal, Usuario, Nombre, Apellido_Paterno, Apellido_Materno, Cargo FROM PERSONAL";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUsuario.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        // BOTÓN ELIMINAR (button3)
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Selecciona un usuario de la tabla para eliminar.");
                return;
            }

            if (MessageBox.Show("¿Seguro que deseas eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = ConexionBD.Conectar())
                    {
                        con.Open();
                        string query = "DELETE FROM PERSONAL WHERE IdPersonal=@id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario eliminado.");
                        Limpiar();
                        CargarUsuarios();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        // SELECCIONAR FILA DE LA TABLA
        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuario.Rows[e.RowIndex];
                txtId.Text = fila.Cells["IdPersonal"].Value.ToString();
                txtUsuario.Text = fila.Cells["Usuario"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtApellidoPaterno.Text = fila.Cells["Apellido_Paterno"].Value.ToString();
                txtApellidoMaterno.Text = fila.Cells["Apellido_Materno"].Value.ToString();
                txtCargo.Text = fila.Cells["Cargo"].Value.ToString();
            }
        }

        // BOTÓN GUARDAR (CREATE)
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = ConexionBD.Conectar())
                {
                    con.Open();
                    string query = @"INSERT INTO PERSONAL (Usuario, Password, Nombre, Apellido_Paterno, Apellido_Materno, Cargo) 
                                     VALUES (@usuario, @password, @nombre, @paterno, @materno, @cargo)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@paterno", txtApellidoPaterno.Text);
                    cmd.Parameters.AddWithValue("@materno", txtApellidoMaterno.Text);
                    cmd.Parameters.AddWithValue("@cargo", txtCargo.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario guardado correctamente.");
                    Limpiar();
                    CargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        // BOTÓN ACTUALIZAR (UPDATE)
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Selecciona un usuario de la tabla primero.");
                return;
            }

            try
            {
                using (SqlConnection con = ConexionBD.Conectar())
                {
                    con.Open();
                    string query = @"UPDATE PERSONAL SET Usuario=@usuario, Password=@password, Nombre=@nombre, 
                                     Apellido_Paterno=@paterno, Apellido_Materno=@materno, Cargo=@cargo 
                                     WHERE IdPersonal=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@paterno", txtApellidoPaterno.Text);
                    cmd.Parameters.AddWithValue("@materno", txtApellidoMaterno.Text);
                    cmd.Parameters.AddWithValue("@cargo", txtCargo.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario actualizado.");
                    Limpiar();
                    CargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        // BOTÓN LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtId.Clear();
            txtUsuario.Clear();
            txtPassword.Clear();
            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtCargo.Clear();
            txtUsuario.Focus();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}