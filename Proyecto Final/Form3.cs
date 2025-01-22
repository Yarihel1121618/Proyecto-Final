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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            using (SqlConnection connection = ConexionDB.GetConnection())
            {
                
                SqlDataAdapter da = new SqlDataAdapter("SELECT CategoriaID, Nombre, Descripcion FROM Categorias", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCategorias.DataSource = dt;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ConexionDB.GetConnection())
            {
                
                SqlCommand cmd = new SqlCommand("INSERT INTO Categorias (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)", connection);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Descripcion", rtxtDescripcion.Text);
                cmd.ExecuteNonQuery();
            }
            LimpiarCampos();
            CargarCategorias();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, selecciona una categoría para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(rtxtDescripcion.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            using (SqlConnection connection = ConexionDB.GetConnection())
            {
                
                SqlCommand cmd = new SqlCommand("UPDATE Categorias SET Nombre = @Nombre, Descripcion = @Descripcion WHERE CategoriaID = @CategoriaID", connection);

                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Descripcion", rtxtDescripcion.Text);
                cmd.Parameters.AddWithValue("@CategoriaID", Convert.ToInt32(txtId.Text)); // Conversión a INT para evitar problemas de tipo

                cmd.ExecuteNonQuery();
            }

            LimpiarCampos();
            CargarCategorias();
            MessageBox.Show("Categoría actualizada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, selecciona una categoría para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            var confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar esta categoría?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

         
            using (SqlConnection connection = ConexionDB.GetConnection())
            {
                
                SqlCommand cmd = new SqlCommand("DELETE FROM Categorias WHERE CategoriaID = @CategoriaID", connection);

                cmd.Parameters.AddWithValue("@CategoriaID", Convert.ToInt32(txtId.Text)); // Conversión a INT para evitar problemas de tipo

                cmd.ExecuteNonQuery();
            }

            LimpiarCampos();
            CargarCategorias();
            MessageBox.Show("Categoría eliminada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            rtxtDescripcion.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategorias.Rows[e.RowIndex];
                txtId.Text = row.Cells["CategoriaID"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                rtxtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
            }
        }
    }
}



