namespace Proyecto_Final
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbCategoria = new ComboBox();
            cmbProveedor = new ComboBox();
            dgvResultados = new DataGridView();
            btnGenerarReporte = new Button();
            btnExportarDatos = new Button();
            label2 = new Label();
            label1 = new Label();
            tabControl = new TabControl();
            tabConsulta = new TabPage();
            tabReporte = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(104, 57);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(177, 23);
            cmbCategoria.TabIndex = 0;
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(104, 102);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(177, 23);
            cmbProveedor.TabIndex = 1;
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(29, 145);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(413, 278);
            dgvResultados.TabIndex = 2;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.ForeColor = Color.Black;
            btnGenerarReporte.Location = new Point(497, 414);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(113, 25);
            btnGenerarReporte.TabIndex = 4;
            btnGenerarReporte.Text = "Genarar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // btnExportarDatos
            // 
            btnExportarDatos.ForeColor = Color.Black;
            btnExportarDatos.Location = new Point(637, 414);
            btnExportarDatos.Name = "btnExportarDatos";
            btnExportarDatos.Size = new Size(113, 25);
            btnExportarDatos.TabIndex = 5;
            btnExportarDatos.Text = "Exportar Datos";
            btnExportarDatos.UseVisualStyleBackColor = true;
            btnExportarDatos.Click += btnExportarDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(25, 103);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 7;
            label2.Text = "Proveedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(29, 57);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 8;
            label1.Text = "Categoria";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabConsulta);
            tabControl.Controls.Add(tabReporte);
            tabControl.Location = new Point(448, 57);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(340, 344);
            tabControl.TabIndex = 9;
            // 
            // tabConsulta
            // 
            tabConsulta.ForeColor = Color.White;
            tabConsulta.Location = new Point(4, 24);
            tabConsulta.Name = "tabConsulta";
            tabConsulta.Padding = new Padding(3);
            tabConsulta.Size = new Size(332, 316);
            tabConsulta.TabIndex = 0;
            tabConsulta.Text = "Consulta";
            tabConsulta.UseVisualStyleBackColor = true;
            // 
            // tabReporte
            // 
            tabReporte.Location = new Point(4, 24);
            tabReporte.Name = "tabReporte";
            tabReporte.Padding = new Padding(3);
            tabReporte.Size = new Size(332, 316);
            tabReporte.TabIndex = 1;
            tabReporte.Text = "Reporte";
            tabReporte.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnExportarDatos);
            Controls.Add(btnGenerarReporte);
            Controls.Add(dgvResultados);
            Controls.Add(cmbProveedor);
            Controls.Add(cmbCategoria);
            ForeColor = Color.White;
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCategoria;
        private ComboBox cmbProveedor;
        private DataGridView dgvResultados;
        private Button btnGenerarReporte;
        private Button btnExportarDatos;
        private Label label2;
        private Label label1;
        private TabControl tabControl;
        private TabPage tabConsulta;
        private TabPage tabReporte;
    }
}