namespace FundamentosNetCore
{
    partial class Form02PosicionColores
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
            btnCambiarPosicionBoton = new Button();
            btnCambiarColor = new Button();
            txtPosicionX = new TextBox();
            txtPosicionY = new TextBox();
            txtColorVerde = new TextBox();
            txtColorAzul = new TextBox();
            txtColorRojo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnCambiarPosicionBoton
            // 
            btnCambiarPosicionBoton.Location = new Point(131, 198);
            btnCambiarPosicionBoton.Name = "btnCambiarPosicionBoton";
            btnCambiarPosicionBoton.Size = new Size(111, 23);
            btnCambiarPosicionBoton.TabIndex = 0;
            btnCambiarPosicionBoton.Text = "Cambiar Posición";
            btnCambiarPosicionBoton.UseVisualStyleBackColor = true;
            btnCambiarPosicionBoton.Click += btnCambiarPosicionBoton_Click;
            // 
            // btnCambiarColor
            // 
            btnCambiarColor.Location = new Point(491, 231);
            btnCambiarColor.Name = "btnCambiarColor";
            btnCambiarColor.Size = new Size(100, 23);
            btnCambiarColor.TabIndex = 1;
            btnCambiarColor.Text = "Cambiar Color";
            btnCambiarColor.UseVisualStyleBackColor = true;
            btnCambiarColor.Click += btnCambiarColor_Click;
            // 
            // txtPosicionX
            // 
            txtPosicionX.Location = new Point(142, 108);
            txtPosicionX.Name = "txtPosicionX";
            txtPosicionX.Size = new Size(100, 23);
            txtPosicionX.TabIndex = 2;
            // 
            // txtPosicionY
            // 
            txtPosicionY.Location = new Point(142, 154);
            txtPosicionY.Name = "txtPosicionY";
            txtPosicionY.Size = new Size(100, 23);
            txtPosicionY.TabIndex = 3;
            // 
            // txtColorVerde
            // 
            txtColorVerde.Location = new Point(491, 132);
            txtColorVerde.Name = "txtColorVerde";
            txtColorVerde.Size = new Size(100, 23);
            txtColorVerde.TabIndex = 4;
            // 
            // txtColorAzul
            // 
            txtColorAzul.Location = new Point(491, 174);
            txtColorAzul.Name = "txtColorAzul";
            txtColorAzul.Size = new Size(100, 23);
            txtColorAzul.TabIndex = 5;
            // 
            // txtColorRojo
            // 
            txtColorRojo.Location = new Point(491, 85);
            txtColorRojo.Name = "txtColorRojo";
            txtColorRojo.Size = new Size(100, 23);
            txtColorRojo.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(425, 93);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 7;
            label1.Text = "Rojo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 140);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 8;
            label2.Text = "Verde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 182);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 9;
            label3.Text = "Azul";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 162);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 10;
            label4.Text = "Posición Y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 111);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 11;
            label5.Text = "Posición X";
            // 
            // Form02PosicionColores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtColorRojo);
            Controls.Add(txtColorAzul);
            Controls.Add(txtColorVerde);
            Controls.Add(txtPosicionY);
            Controls.Add(txtPosicionX);
            Controls.Add(btnCambiarColor);
            Controls.Add(btnCambiarPosicionBoton);
            Name = "Form02PosicionColores";
            Text = "Form02PosicionColores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCambiarPosicionBoton;
        private Button btnCambiarColor;
        private TextBox txtPosicionX;
        private TextBox txtPosicionY;
        private TextBox txtColorVerde;
        private TextBox txtColorAzul;
        private TextBox txtColorRojo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}