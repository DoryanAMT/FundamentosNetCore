namespace FundamentosNetCore
{
    partial class Form13ColeccionNumeros
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
            lstNumeros = new ListBox();
            btnGenerar = new Button();
            btnMostrarDatos = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSuma = new TextBox();
            txtPares = new TextBox();
            txtImpares = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Números";
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(12, 33);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(162, 379);
            lstNumeros.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(197, 15);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(163, 41);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(197, 62);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(163, 41);
            btnMostrarDatos.TabIndex = 3;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 140);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Suma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 173);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 5;
            label3.Text = "Pares";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 206);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Impares";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(260, 140);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 7;
            // 
            // txtPares
            // 
            txtPares.Location = new Point(260, 173);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(100, 23);
            txtPares.TabIndex = 8;
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(260, 206);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(100, 23);
            txtImpares.TabIndex = 9;
            // 
            // Form13ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 450);
            Controls.Add(txtImpares);
            Controls.Add(txtPares);
            Controls.Add(txtSuma);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnMostrarDatos);
            Controls.Add(btnGenerar);
            Controls.Add(lstNumeros);
            Controls.Add(label1);
            Name = "Form13ColeccionNumeros";
            Text = "Form13ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNumeros;
        private Button btnGenerar;
        private Button btnMostrarDatos;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSuma;
        private TextBox txtPares;
        private TextBox txtImpares;
    }
}