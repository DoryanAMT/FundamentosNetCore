namespace FundamentosNetCore
{
    partial class Form20TestClases
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
            lstClases = new ListBox();
            btnPersona = new Button();
            btnCrearEmpleado = new Button();
            btnDirector = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Clases";
            // 
            // lstClases
            // 
            lstClases.FormattingEnabled = true;
            lstClases.Location = new Point(24, 42);
            lstClases.Name = "lstClases";
            lstClases.Size = new Size(508, 379);
            lstClases.TabIndex = 1;
            // 
            // btnPersona
            // 
            btnPersona.Location = new Point(24, 436);
            btnPersona.Name = "btnPersona";
            btnPersona.Size = new Size(120, 50);
            btnPersona.TabIndex = 2;
            btnPersona.Text = "Persona";
            btnPersona.UseVisualStyleBackColor = true;
            btnPersona.Click += btnPersona_Click;
            // 
            // btnCrearEmpleado
            // 
            btnCrearEmpleado.Location = new Point(150, 436);
            btnCrearEmpleado.Name = "btnCrearEmpleado";
            btnCrearEmpleado.Size = new Size(120, 50);
            btnCrearEmpleado.TabIndex = 3;
            btnCrearEmpleado.Text = "Empleado";
            btnCrearEmpleado.UseVisualStyleBackColor = true;
            btnCrearEmpleado.Click += btnCrearEmpleado_Click;
            // 
            // btnDirector
            // 
            btnDirector.Location = new Point(276, 436);
            btnDirector.Name = "btnDirector";
            btnDirector.Size = new Size(120, 50);
            btnDirector.TabIndex = 4;
            btnDirector.Text = "Director";
            btnDirector.UseVisualStyleBackColor = true;
            btnDirector.Click += btnDirector_Click;
            // 
            // Form20TestClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 526);
            Controls.Add(btnDirector);
            Controls.Add(btnCrearEmpleado);
            Controls.Add(btnPersona);
            Controls.Add(lstClases);
            Controls.Add(label1);
            Name = "Form20TestClases";
            Text = "Form20TestClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstClases;
        private Button btnPersona;
        private Button btnCrearEmpleado;
        private Button btnDirector;
    }
}