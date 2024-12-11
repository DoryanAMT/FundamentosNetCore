namespace FundamentosNetCore
{
    partial class Form03DiaNacimiento
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
            btnCalcularDiaNacimiento = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAnio = new TextBox();
            lblDiaSemana = new Label();
            SuspendLayout();
            // 
            // btnCalcularDiaNacimiento
            // 
            btnCalcularDiaNacimiento.Location = new Point(226, 86);
            btnCalcularDiaNacimiento.Name = "btnCalcularDiaNacimiento";
            btnCalcularDiaNacimiento.Size = new Size(106, 80);
            btnCalcularDiaNacimiento.TabIndex = 0;
            btnCalcularDiaNacimiento.Text = "Calcular día nacimeinto";
            btnCalcularDiaNacimiento.UseVisualStyleBackColor = true;
            btnCalcularDiaNacimiento.Click += btnCalcularDiaNacimiento_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 68);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 1;
            label1.Text = "Día";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 125);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 188);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 3;
            label3.Text = "Año";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(48, 86);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 4;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(48, 143);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 5;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(48, 206);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(100, 23);
            txtAnio.TabIndex = 6;
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Location = new Point(244, 188);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(79, 15);
            lblDiaSemana.TabIndex = 7;
            lblDiaSemana.Text = "lblDiaSemana";
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDiaSemana);
            Controls.Add(txtAnio);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcularDiaNacimiento);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcularDiaNacimiento;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnio;
        private Label lblDiaSemana;
    }
}