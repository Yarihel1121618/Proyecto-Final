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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }





        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            // Lógica para buscar productos por nombre o código
            string nombre = txtBuscarNombre.Text.Trim();
            string codigo = txtBuscarCodigo.Text.Trim();

            using (SqlConnection connection = ConexionDB.GetConnection())
            {
                
                SqlCommand cmd = new SqlCommand("sp_BuscarProductos", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", string.IsNullOrEmpty(nombre) ? (object)DBNull.Value : nombre);
                cmd.Parameters.AddWithValue("@Codigo", string.IsNullOrEmpty(codigo) ? (object)DBNull.Value : codigo);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvResultados.DataSource = dt;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            // Lógica para exportar los datos mostrados en el DataGridView a un archivo CSV
            if (dgvResultados.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "ResultadosBusqueda.csv";
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
