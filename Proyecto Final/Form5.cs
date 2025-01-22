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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            CargarCategorias();
            CargarProveedores();
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

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            // Lógica para generar el reporte según los filtros seleccionados
            int? categoriaId = cmbCategoria.SelectedItem != null ? (int?)((dynamic)cmbCategoria.SelectedItem).Value : null;
            int? proveedorId = cmbProveedor.SelectedItem != null ? (int?)((dynamic)cmbProveedor.SelectedItem).Value : null;

            using (SqlConnection connection = ConexionDB.GetConnection())
            {
                
                SqlCommand cmd = new SqlCommand("sp_ConsultaPorCategoriaProveedor", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaID", (object)categoriaId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ProveedorID", (object)proveedorId ?? DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvResultados.DataSource = dt;
            }
        }

        private void btnExportarDatos_Click(object sender, EventArgs e)
        {
            // Lógica para exportar los datos mostrados en el DataGridView a un archivo CSV
            if (dgvResultados.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "Reporte.csv";
                sfd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();
                    // Agregar encabezados
                    string[] columnNames = dgvResultados.Columns.Cast<DataGridViewColumn>()
                        .Select(column => column.HeaderText)
                        .ToArray();
                    sb.AppendLine(string.Join(",", columnNames));

                    // Agregar filas
                    foreach (DataGridViewRow row in dgvResultados.Rows)
                    {
                        string[] cells = row.Cells.Cast<DataGridViewCell>()
                            .Select(cell => cell.Value?.ToString().Replace(",", ";")) // Reemplazar comas para evitar problemas en CSV
                            .ToArray();
                        sb.AppendLine(string.Join(",", cells));
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString());
                    MessageBox.Show("Datos exportados exitosamente.", "Exportar Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No hay datos para exportar.", "Exportar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
