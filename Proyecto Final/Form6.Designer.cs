namespace Proyecto_Final
{
    partial class Form6
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
            groupBoxBusqueda = new GroupBox();
            txtBuscarCodigo = new TextBox();
            txtBuscarNombre = new TextBox();
            groupBoxExportacion = new GroupBox();
            btnExportar = new Button();
            btnBuscar = new Button();
            dgvResultados = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // groupBoxBusqueda
            // 
            groupBoxBusqueda.Location = new Point(103, 81);
            groupBoxBusqueda.Name = "groupBoxBusqueda";
            groupBoxBusqueda.Size = new Size(272, 42);
            groupBoxBusqueda.TabIndex = 0;
            groupBoxBusqueda.TabStop = false;
            groupBoxBusqueda.Text = "Busqueda";
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.Location = new Point(103, 189);
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.Size = new Size(272, 23);
            txtBuscarCodigo.TabIndex = 1;
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new Point(103, 144);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(272, 23);
            txtBuscarNombre.TabIndex = 2;
            // 
            // groupBoxExportacion
            // 
            groupBoxExportacion.Location = new Point(103, 233);
            groupBoxExportacion.Name = "groupBoxExportacion";
            groupBoxExportacion.Size = new Size(272, 39);
            groupBoxExportacion.TabIndex = 1;
            groupBoxExportacion.TabStop = false;
            groupBoxExportacion.Text = "Exportacion";
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(477, 374);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(179, 28);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(103, 374);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(179, 28);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(430, 81);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(339, 218);
            dgvResultados.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 145);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 11;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 195);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 12;
            label2.Text = "Codigo";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvResultados);
            Controls.Add(btnBuscar);
            Controls.Add(btnExportar);
            Controls.Add(groupBoxExportacion);
            Controls.Add(txtBuscarNombre);
            Controls.Add(txtBuscarCodigo);
            Controls.Add(groupBoxBusqueda);
            Name = "Form6";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxBusqueda;
        private TextBox txtBuscarCodigo;
        private TextBox txtBuscarNombre;
        private GroupBox groupBoxExportacion;
        private Button btnExportar;
        private Button btnBuscar;
        private DataGridView dgvResultados;
        private Label label1;
        private Label label2;
    }
}