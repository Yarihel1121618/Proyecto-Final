namespace Proyecto_Final
{
    partial class Form4
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
            lblId = new Label();
            lblEmpresa = new Label();
            lblContacto = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            txtId = new TextBox();
            txtContacto = new TextBox();
            txtEmpresa = new TextBox();
            txtDireccion = new TextBox();
            mtxtTelefono = new MaskedTextBox();
            dgvProveedores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblId.Location = new Point(127, 59);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 17);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblEmpresa.Location = new Point(89, 116);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(60, 17);
            lblEmpresa.TabIndex = 1;
            lblEmpresa.Text = "Empresa";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblContacto.Location = new Point(413, 59);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(63, 17);
            lblContacto.TabIndex = 2;
            lblContacto.Text = "Contacto";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblTelefono.Location = new Point(414, 116);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(62, 17);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblDireccion.Location = new Point(83, 175);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(66, 17);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Direccion";
            // 
            // btnLimpiar
            // 
            btnLimpiar.ForeColor = Color.Black;
            btnLimpiar.Location = new Point(549, 391);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(102, 22);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(396, 391);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 22);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.ForeColor = Color.Black;
            btnEditar.Location = new Point(251, 391);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(102, 22);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(105, 391);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 22);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(155, 58);
            txtId.Name = "txtId";
            txtId.Size = new Size(188, 23);
            txtId.TabIndex = 23;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(485, 53);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(188, 23);
            txtContacto.TabIndex = 24;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(155, 110);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(188, 23);
            txtEmpresa.TabIndex = 25;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(155, 174);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(518, 23);
            txtDireccion.TabIndex = 26;
            // 
            // mtxtTelefono
            // 
            mtxtTelefono.Location = new Point(485, 110);
            mtxtTelefono.Name = "mtxtTelefono";
            mtxtTelefono.Size = new Size(188, 23);
            mtxtTelefono.TabIndex = 27;
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(73, 225);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.Size = new Size(627, 150);
            dgvProveedores.TabIndex = 28;
            dgvProveedores.CellContentClick += dgvProveedores_CellContentClick_1;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProveedores);
            Controls.Add(mtxtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtEmpresa);
            Controls.Add(txtContacto);
            Controls.Add(txtId);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(lblDireccion);
            Controls.Add(lblTelefono);
            Controls.Add(lblContacto);
            Controls.Add(lblEmpresa);
            Controls.Add(lblId);
            ForeColor = Color.White;
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblEmpresa;
        private Label lblContacto;
        private Label lblTelefono;
        private Label lblDireccion;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private TextBox txtId;
        private TextBox txtContacto;
        private TextBox txtEmpresa;
        private TextBox txtDireccion;
        private MaskedTextBox mtxtTelefono;
        private DataGridView dgvProveedores;
    }
}