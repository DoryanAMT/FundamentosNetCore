namespace FundamentosNetCore
{
    partial class Form10Dni
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
            btnComprobar = new Button();
            label1 = new Label();
            lblResultado = new Label();
            txtDni = new TextBox();
            SuspendLayout();
            // 
            // btnComprobar
            // 
            btnComprobar.Location = new Point(42, 76);
            btnComprobar.Name = "btnComprobar";
            btnComprobar.Size = new Size(135, 23);
            btnComprobar.TabIndex = 0;
            btnComprobar.Text = "Comprobar";
            btnComprobar.UseVisualStyleBackColor = true;
            btnComprobar.Click += btnComprobar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 29);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Introduce DNi:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(42, 112);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "lblResultado";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(41, 47);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(136, 23);
            txtDni.TabIndex = 3;
            // 
            // Form10Dni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDni);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(btnComprobar);
            Name = "Form10Dni";
            Text = "Form10Dni";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnComprobar;
        private Label label1;
        private Label lblResultado;
        private TextBox txtDni;
    }
}