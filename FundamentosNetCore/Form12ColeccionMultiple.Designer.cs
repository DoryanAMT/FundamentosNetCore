namespace FundamentosNetCore
{
    partial class Form12ColeccionMultiple
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
            label4 = new Label();
            lblItemSeleccionado = new Label();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            btnInsertar = new Button();
            txtNuevoElemento = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lstElementos = new ListBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 414);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // lblItemSeleccionado
            // 
            lblItemSeleccionado.AutoSize = true;
            lblItemSeleccionado.Location = new Point(12, 380);
            lblItemSeleccionado.Name = "lblItemSeleccionado";
            lblItemSeleccionado.Size = new Size(38, 15);
            lblItemSeleccionado.TabIndex = 16;
            lblItemSeleccionado.Text = "label3";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(245, 127);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 50);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(245, 183);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(125, 50);
            btnBorrarTodo.TabIndex = 14;
            btnBorrarTodo.Text = "Borrar Todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(245, 71);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(125, 50);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(245, 29);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(125, 23);
            txtNuevoElemento.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 11);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 11;
            label2.Text = "Nuevo Elemento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 10;
            label1.Text = "Elementos";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(12, 29);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(194, 334);
            lstElementos.TabIndex = 9;
            // 
            // Form12ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 450);
            Controls.Add(label4);
            Controls.Add(lblItemSeleccionado);
            Controls.Add(btnEliminar);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnInsertar);
            Controls.Add(txtNuevoElemento);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstElementos);
            Name = "Form12ColeccionMultiple";
            Text = "Form12ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label lblItemSeleccionado;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Button btnInsertar;
        private TextBox txtNuevoElemento;
        private Label label2;
        private Label label1;
        private ListBox lstElementos;
    }
}