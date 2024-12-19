namespace FundamentosNetCore
{
    partial class Form15Metodos
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
            lblResultado = new Label();
            txtNuemero = new TextBox();
            btnDobleValor = new Button();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            label2 = new Label();
            txtSoloNumeros = new TextBox();
            txtSoloLetras = new TextBox();
            label3 = new Label();
            lblRaton = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 28);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(45, 91);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "lblResultado";
            // 
            // txtNuemero
            // 
            txtNuemero.Location = new Point(45, 46);
            txtNuemero.Name = "txtNuemero";
            txtNuemero.Size = new Size(100, 23);
            txtNuemero.TabIndex = 2;
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(41, 126);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(104, 57);
            btnDobleValor.TabIndex = 3;
            btnDobleValor.Text = "Doble Valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(41, 189);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(104, 57);
            btnDobleReferencia.TabIndex = 4;
            btnDobleReferencia.Text = "Doble Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(41, 252);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(104, 57);
            btnObjetoReferencia.TabIndex = 5;
            btnObjetoReferencia.Text = "Objeto Referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 28);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 6;
            label2.Text = "Sólo números";
            // 
            // txtSoloNumeros
            // 
            txtSoloNumeros.Location = new Point(198, 46);
            txtSoloNumeros.Name = "txtSoloNumeros";
            txtSoloNumeros.Size = new Size(134, 23);
            txtSoloNumeros.TabIndex = 7;
            txtSoloNumeros.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // txtSoloLetras
            // 
            txtSoloLetras.Location = new Point(194, 116);
            txtSoloLetras.Name = "txtSoloLetras";
            txtSoloLetras.Size = new Size(134, 23);
            txtSoloLetras.TabIndex = 9;
            txtSoloLetras.KeyPress += txtSoloLetras_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 98);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 8;
            label3.Text = "Sólo letras";
            // 
            // lblRaton
            // 
            lblRaton.BackColor = Color.LawnGreen;
            lblRaton.Location = new Point(194, 175);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(257, 200);
            lblRaton.TabIndex = 10;
            lblRaton.Text = "lblRaton";
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // Form15Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 497);
            Controls.Add(lblRaton);
            Controls.Add(txtSoloLetras);
            Controls.Add(label3);
            Controls.Add(txtSoloNumeros);
            Controls.Add(label2);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnDobleValor);
            Controls.Add(txtNuemero);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Name = "Form15Metodos";
            Text = "Form15Metodos";
            FormClosed += Form15Metodos_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResultado;
        private TextBox txtNuemero;
        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private Label label2;
        private TextBox txtSoloNumeros;
        private TextBox txtSoloLetras;
        private Label label3;
        private Label lblRaton;
    }
}