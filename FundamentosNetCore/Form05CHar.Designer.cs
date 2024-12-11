namespace FundamentosNetCore
{
    partial class Form05CHar
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
            txtNumeros = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtLetras = new TextBox();
            label3 = new Label();
            txtSimbolos = new TextBox();
            label4 = new Label();
            txtPuntuacion = new TextBox();
            btnRun = new Button();
            SuspendLayout();
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(39, 45);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(303, 154);
            txtNumeros.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 27);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Números";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(430, 27);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "Letras";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(430, 45);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(303, 154);
            txtLetras.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 232);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Símbolos";
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(39, 250);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(303, 154);
            txtSimbolos.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(430, 232);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 7;
            label4.Text = "Puntuación";
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(430, 250);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(303, 154);
            txtPuntuacion.TabIndex = 6;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(315, 431);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(147, 77);
            btnRun.TabIndex = 8;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // Form05CHar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 520);
            Controls.Add(btnRun);
            Controls.Add(label4);
            Controls.Add(txtPuntuacion);
            Controls.Add(label3);
            Controls.Add(txtSimbolos);
            Controls.Add(label2);
            Controls.Add(txtLetras);
            Controls.Add(label1);
            Controls.Add(txtNumeros);
            Name = "Form05CHar";
            Text = "Form05CHar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumeros;
        private Label label1;
        private Label label2;
        private TextBox txtLetras;
        private Label label3;
        private TextBox txtSimbolos;
        private Label label4;
        private TextBox txtPuntuacion;
        private Button btnRun;
    }
}