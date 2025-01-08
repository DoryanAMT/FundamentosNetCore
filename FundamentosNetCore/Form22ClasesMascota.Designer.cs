namespace FundamentosNetCore
{
    partial class Form22ClasesMascota
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            label2 = new Label();
            btnNuevaMascota = new Button();
            Mascotas = new Label();
            lstMascotas = new ListBox();
            btnLeerMascota = new Button();
            btnGuardarMascotas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(25, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(137, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(25, 90);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(137, 23);
            txtRaza.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 72);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Raza";
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(25, 129);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(137, 44);
            btnNuevaMascota.TabIndex = 4;
            btnNuevaMascota.Text = "Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            // 
            // Mascotas
            // 
            Mascotas.AutoSize = true;
            Mascotas.Location = new Point(193, 18);
            Mascotas.Name = "Mascotas";
            Mascotas.Size = new Size(57, 15);
            Mascotas.TabIndex = 5;
            Mascotas.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(193, 36);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(236, 334);
            lstMascotas.TabIndex = 6;
            // 
            // btnLeerMascota
            // 
            btnLeerMascota.Location = new Point(25, 188);
            btnLeerMascota.Name = "btnLeerMascota";
            btnLeerMascota.Size = new Size(137, 44);
            btnLeerMascota.TabIndex = 7;
            btnLeerMascota.Text = "Leer Mascotas";
            btnLeerMascota.UseVisualStyleBackColor = true;
            // 
            // btnGuardarMascotas
            // 
            btnGuardarMascotas.Location = new Point(25, 249);
            btnGuardarMascotas.Name = "btnGuardarMascotas";
            btnGuardarMascotas.Size = new Size(137, 44);
            btnGuardarMascotas.TabIndex = 8;
            btnGuardarMascotas.Text = "Guardar Mascotas";
            btnGuardarMascotas.UseVisualStyleBackColor = true;
            // 
            // Form22ClasesMascota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 450);
            Controls.Add(btnGuardarMascotas);
            Controls.Add(btnLeerMascota);
            Controls.Add(lstMascotas);
            Controls.Add(Mascotas);
            Controls.Add(btnNuevaMascota);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form22ClasesMascota";
            Text = "Form22ClasesMascota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private Label label2;
        private Button btnNuevaMascota;
        private Label Mascotas;
        private ListBox lstMascotas;
        private Button btnLeerMascota;
        private Button btnGuardarMascotas;
    }
}