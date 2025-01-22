namespace Proyecto_Final
{
    partial class Form2
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
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new NumericUpDown();
            txtExistencia = new NumericUpDown();
            cmbCategoria = new ComboBox();
            cmbProveedor = new ComboBox();
            lblCodigo = new Label();
            lblPrecio = new Label();
            lblExistencia = new Label();
            lblCategoria = new Label();
            lblProveedor = new Label();
            lblNombre = new Label();
            dgvProductos = new DataGridView();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)txtPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtExistencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(158, 28);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(156, 23);
            txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(508, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(156, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(158, 85);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(156, 23);
            txtPrecio.TabIndex = 2;
            // 
            // txtExistencia
            // 
            txtExistencia.Location = new Point(508, 85);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.Size = new Size(156, 23);
            txtExistencia.TabIndex = 3;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(158, 138);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(156, 23);
            cmbCategoria.TabIndex = 4;
            // 
            // cmbProveedor
            // 
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(508, 138);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(156, 23);
            cmbProveedor.TabIndex = 5;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.ForeColor = Color.White;
            lblCodigo.Location = new Point(94, 31);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(56, 17);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "Codigo ";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.White;
            lblPrecio.Location = new Point(95, 90);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(46, 17);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio";
            // 
            // lblExistencia
            // 
            lblExistencia.AutoSize = true;
            lblExistencia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistencia.ForeColor = Color.White;
            lblExistencia.Location = new Point(430, 91);
            lblExistencia.Name = "lblExistencia";
            lblExistencia.Size = new Size(69, 17);
            lblExistencia.TabIndex = 9;
            lblExistencia.Text = "Existencia";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.ForeColor = Color.White;
            lblCategoria.Location = new Point(70, 143);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(71, 17);
            lblCategoria.TabIndex = 10;
            lblCategoria.Text = "Categoria ";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProveedor.ForeColor = Color.White;
            lblProveedor.Location = new Point(427, 142);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(75, 17);
            lblProveedor.TabIndex = 11;
            lblProveedor.Text = "Proveedor ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(441, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 17);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(55, 189);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(682, 209);
            dgvProductos.TabIndex = 13;
            // 
            // btnLimpiar
            // 
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Location = new Point(558, 416);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(102, 22);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(405, 416);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 22);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(260, 416);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(102, 22);
            btnEditar.TabIndex = 23;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(114, 416);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 22);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvProductos);
            Controls.Add(lblNombre);
            Controls.Add(lblProveedor);
            Controls.Add(lblCategoria);
            Controls.Add(lblExistencia);
            Controls.Add(lblPrecio);
            Controls.Add(lblCodigo);
            Controls.Add(cmbProveedor);
            Controls.Add(cmbCategoria);
            Controls.Add(txtExistencia);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)txtPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtExistencia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private TextBox txtNombre;
        private NumericUpDown txtPrecio;
        private NumericUpDown txtExistencia;
        private ComboBox cmbCategoria;
        private ComboBox cmbProveedor;
        private Label lblCodigo;
        private Label lblPrecio;
        private Label lblExistencia;
        private Label lblCategoria;
        private Label lblProveedor;
        private Label lblNombre;
        private DataGridView dgvProductos;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
    }
}