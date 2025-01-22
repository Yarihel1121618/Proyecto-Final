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

namespace Proyecto_Final
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            using (SqlConnection connection = ConexionDB.GetConnection())
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT ProveedorID, NombreEmpresa, Contacto, Direccion, Telefono FROM Proveedores", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProveedores.DataSource = dt;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConexionDB.GetConnection())
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO Proveedores (NombreEmpresa, Contacto, Direccion, Telefono) VALUES (@NombreEmpresa, @Contacto, @Direccion, @Telefono)", connection);
                cmd.Parameters.AddWithValue("@NombreEmpresa", txtEmpresa.Text);
                cmd.Parameters.AddWithValue("@Contacto", txtContacto.Text);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@Telefono", mtxtTelefono.Text);
                cmd.ExecuteNonQuery();
            }
            LimpiarCampos();
            CargarProveedores();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConexionDB.GetConnection())
            {

                SqlCommand cmd = new SqlCommand("UPDATE Proveedores SET NombreEmpresa = @NombreEmpresa, Contacto = @Contacto, Direccion = @Direccion, Telefono = @Telefono WHERE ProveedorID = @ProveedorID", connection);
                cmd.Parameters.AddWithValue("@NombreEmpresa", txtEmpresa.Text);
                cmd.Parameters.AddWithValue("@Contacto", txtContacto.Text);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@Telefono", mtxtTelefono.Text);
                cmd.Parameters.AddWithValue("@ProveedorID", txtId.Text);
                cmd.ExecuteNonQuery();
            }
            LimpiarCampos();
            CargarProveedores();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConexionDB.GetConnection())
            {

                SqlCommand cmd = new SqlCommand("DELETE FROM Proveedores WHERE ProveedorID = @ProveedorID", connection);
                cmd.Parameters.AddWithValue("@ProveedorID", txtId.Text);
                cmd.ExecuteNonQuery();
            }
            LimpiarCampos();
            CargarProveedores();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtEmpresa.Clear();
            txtContacto.Clear();
            txtDireccion.Clear();
            mtxtTelefono.Clear();
        }

     

        private void dgvProveedores_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProveedores.Rows[e.RowIndex];
                txtId.Text = row.Cells["ProveedorID"].Value.ToString();
                txtEmpresa.Text = row.Cells["NombreEmpresa"].Value.ToString();
                txtContacto.Text = row.Cells["Contacto"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                mtxtTelefono.Text = row.Cells["Telefono"].Value.ToString();
            }
        }
    }
}
