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
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
            CargarProductos();
            CargarCategorias();
            CargarProveedores();
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text; 
            }
        }
        private void CargarProductos()
        {
            using (SqlConnection connection = ConexionDB.GetConnection())
            {
                
                SqlDataAdapter da = new SqlDataAdapter("SELECT ProductoID, Codigo, Nombre, Precio, Existencia, CategoriaID, ProveedorID FROM Productos", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProductos.DataSource = dt;
            }
        }

        private void CargarCategorias()
        {
            using (SqlConnection connection = ConexionDB.GetConnection())
            {
                
                SqlCommand cmd = new SqlCommand("SELECT CategoriaID, Nombre FROM Categorias", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbCategoria.Items.Add(new { Text = reader["Nombre"].ToString(), Value = reader["CategoriaID"] });
                }
                cmbCategoria.DisplayMember = "Text";
                cmbCategoria.ValueMember = "Value";
            }
        }

        private void CargarProveedores()
        {
            using (SqlConnection connection = ConexionDB.GetConnection())
            {
                
                SqlCommand cmd = new SqlCommand("SELECT ProveedorID, NombreEmpresa FROM Proveedores", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbProveedor.Items.Add(new { Text = reader["NombreEmpresa"].ToString(), Value = reader["ProveedorID"] });
                }
                cmbProveedor.DisplayMember = "Text";
                cmbProveedor.ValueMember = "Value";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConexionDB.GetConnection())
            {
                
                SqlCommand cmd = new SqlCommand("INSERT INTO Productos (Codigo, Nombre, Precio, Existencia, CategoriaID, ProveedorID) " +
                    "VALUES (@Codigo, @Nombre, @Precio, @Existencia, @CategoriaID, @ProveedorID)", connection);
                cmd.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Precio", Convert.ToDecimal(txtPrecio.Text));
                cmd.Parameters.AddWithValue("@Existencia", Convert.ToInt32(txtExistencia.Text));
                cmd.Parameters.AddWithValue("@CategoriaID", ((dynamic)cmbCategoria.SelectedItem).Value);
                cmd.Parameters.AddWithValue("@ProveedorID", ((dynamic)cmbProveedor.SelectedItem).Value);
                cmd.ExecuteNonQuery();
            }
            LimpiarCampos();
            CargarProductos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Por favor, selecciona un producto para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategoria.SelectedItem == null || cmbProveedor.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una categoría y un proveedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = ConexionDB.GetConnection())
            {
                
                SqlCommand cmd = new SqlCommand("UPDATE Productos SET Codigo = @Codigo, Nombre = @Nombre, Precio = @Precio, Existencia = @Existencia, " +
                    "CategoriaID = @CategoriaID, ProveedorID = @ProveedorID WHERE ProductoID = @ProductoID", connection);

                cmd.Parameters.Add("@Codigo", SqlDbType.NVarChar).Value = txtCodigo.Text;
                cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = txtNombre.Text;
                cmd.Parameters.Add("@Precio", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPrecio.Text);
                cmd.Parameters.Add("@Existencia", SqlDbType.Int).Value = Convert.ToInt32(txtExistencia.Text);
                cmd.Parameters.Add("@CategoriaID", SqlDbType.Int).Value = ((ComboBoxItem)cmbCategoria.SelectedItem).Value;
                cmd.Parameters.Add("@ProveedorID", SqlDbType.Int).Value = ((ComboBoxItem)cmbProveedor.SelectedItem).Value;
                cmd.Parameters.Add("@ProductoID", SqlDbType.Int).Value = dgvProductos.CurrentRow.Cells["ProductoID"].Value;

                cmd.ExecuteNonQuery();
            }

            LimpiarCampos();
            CargarProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConexionDB.GetConnection())
            {
                
                SqlCommand cmd = new SqlCommand("DELETE FROM Productos WHERE ProductoID = @ProductoID", connection);
                cmd.Parameters.AddWithValue("@ProductoID", dgvProductos.CurrentRow.Cells["ProductoID"].Value);
                cmd.ExecuteNonQuery();
            }
            LimpiarCampos();
            CargarProductos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Value = txtPrecio.Minimum; 
            txtExistencia.Value = txtExistencia.Minimum; 
            cmbCategoria.SelectedIndex = -1; 
            cmbProveedor.SelectedIndex = -1; 
        }
    }



}
