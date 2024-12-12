namespace FundamentosNetCore
{
    partial class Form09Isbn
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
            btnCompobarIsbn = new Button();
            txtIsbn = new TextBox();
            label1 = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnCompobarIsbn
            // 
            btnCompobarIsbn.Location = new Point(43, 82);
            btnCompobarIsbn.Name = "btnCompobarIsbn";
            btnCompobarIsbn.Size = new Size(155, 23);
            btnCompobarIsbn.TabIndex = 0;
            btnCompobarIsbn.Text = "Comprobar";
            btnCompobarIsbn.UseVisualStyleBackColor = true;
            btnCompobarIsbn.Click += btnCompobarIsbn_Click;
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(43, 53);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(155, 23);
            txtIsbn.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 35);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 2;
            label1.Text = "Introduce ISBN: ";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(88, 118);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            // 
            // Form09Isbn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 163);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(txtIsbn);
            Controls.Add(btnCompobarIsbn);
            Name = "Form09Isbn";
            Text = "Form09Isbn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCompobarIsbn;
        private TextBox txtIsbn;
        private Label label1;
        private Label lblResultado;
    }
}