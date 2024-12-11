namespace FundamentosNetCore
{
    partial class Form04DateTime
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
            groupBox1 = new GroupBox();
            btnIncrementar = new Button();
            txtIncremento = new TextBox();
            label2 = new Label();
            rdbAnios = new RadioButton();
            rdbMeses = new RadioButton();
            rdbDias = new RadioButton();
            label1 = new Label();
            txtFechaActual = new TextBox();
            chkCambiarFormato = new CheckBox();
            label3 = new Label();
            txtNuevaFecha = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIncrementar);
            groupBox1.Controls.Add(txtIncremento);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rdbAnios);
            groupBox1.Controls.Add(rdbMeses);
            groupBox1.Controls.Add(rdbDias);
            groupBox1.Location = new Point(24, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(197, 80);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(100, 23);
            btnIncrementar.TabIndex = 5;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(197, 52);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 23);
            txtIncremento.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 34);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Incremento";
            // 
            // rdbAnios
            // 
            rdbAnios.AutoSize = true;
            rdbAnios.Location = new Point(17, 84);
            rdbAnios.Name = "rdbAnios";
            rdbAnios.Size = new Size(52, 19);
            rdbAnios.TabIndex = 2;
            rdbAnios.TabStop = true;
            rdbAnios.Text = "Años";
            rdbAnios.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(17, 59);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(58, 19);
            rdbMeses.TabIndex = 1;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(17, 34);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(47, 19);
            rdbDias.TabIndex = 0;
            rdbDias.TabStop = true;
            rdbDias.Text = "Días";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "Fecha Actual";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(24, 42);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(314, 23);
            txtFechaActual.TabIndex = 2;
            // 
            // chkCambiarFormato
            // 
            chkCambiarFormato.AutoSize = true;
            chkCambiarFormato.Location = new Point(24, 71);
            chkCambiarFormato.Name = "chkCambiarFormato";
            chkCambiarFormato.Size = new Size(149, 19);
            chkCambiarFormato.TabIndex = 3;
            chkCambiarFormato.Text = "Cambiar formato fecha";
            chkCambiarFormato.UseVisualStyleBackColor = true;
            chkCambiarFormato.CheckedChanged += chkCambiarFormato_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 279);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 4;
            label3.Text = "Nueva Fecha";
            // 
            // txtNuevaFecha
            // 
            txtNuevaFecha.Location = new Point(24, 297);
            txtNuevaFecha.Name = "txtNuevaFecha";
            txtNuevaFecha.Size = new Size(314, 23);
            txtNuevaFecha.TabIndex = 5;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNuevaFecha);
            Controls.Add(label3);
            Controls.Add(chkCambiarFormato);
            Controls.Add(txtFechaActual);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtIncremento;
        private Label label2;
        private RadioButton rdbAnios;
        private RadioButton rdbMeses;
        private RadioButton rdbDias;
        private TextBox txtFechaActual;
        private CheckBox chkCambiarFormato;
        private Button btnIncrementar;
        private Label label3;
        private TextBox txtNuevaFecha;
    }
}