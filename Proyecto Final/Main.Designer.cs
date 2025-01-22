namespace Proyecto_Final
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            b1 = new Button();
            b4 = new Button();
            b2 = new Button();
            b3 = new Button();
            b5 = new Button();
            SuspendLayout();
            // 
            // b1
            // 
            b1.Location = new Point(29, 12);
            b1.Name = "b1";
            b1.Size = new Size(130, 37);
            b1.TabIndex = 0;
            b1.Text = "Productos";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b4
            // 
            b4.Location = new Point(483, 12);
            b4.Name = "b4";
            b4.Size = new Size(130, 37);
            b4.TabIndex = 3;
            b4.Text = "Consultas y Reportes";
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click;
            // 
            // b2
            // 
            b2.Location = new Point(177, 12);
            b2.Name = "b2";
            b2.Size = new Size(130, 37);
            b2.TabIndex = 5;
            b2.Text = "Categorías";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b3
            // 
            b3.Location = new Point(331, 12);
            b3.Name = "b3";
            b3.Size = new Size(130, 37);
            b3.TabIndex = 6;
            b3.Text = "Proveedores";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b5
            // 
            b5.Location = new Point(642, 12);
            b5.Name = "b5";
            b5.Size = new Size(130, 37);
            b5.TabIndex = 8;
            b5.Text = "Adicionales";
            b5.UseVisualStyleBackColor = true;
            b5.Click += b5_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(799, 519);
            Controls.Add(b5);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b4);
            Controls.Add(b1);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button b1;
        private Button b4;
        private Button b2;
        private Button b3;
        private Button b5;
    }
}
