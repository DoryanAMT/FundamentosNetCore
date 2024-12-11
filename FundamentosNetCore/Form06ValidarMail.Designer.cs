namespace FundamentosNetCore
{
    partial class Form06ValidarMail
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
            btnValidar = new Button();
            label1 = new Label();
            lblResultado = new Label();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(27, 70);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(156, 23);
            btnValidar.TabIndex = 0;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Email:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(27, 107);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "lblResultado";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(27, 41);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(156, 23);
            txtEmail.TabIndex = 3;
            // 
            // Form06ValidarMail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEmail);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(btnValidar);
            Name = "Form06ValidarMail";
            Text = "Form06ValidarMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidar;
        private Label label1;
        private Label lblResultado;
        private TextBox txtEmail;
    }
}