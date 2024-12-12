namespace FundamentosNetCore
{
    partial class Form11ColeccionGrafica
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
            lstElementos = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtNuevoElemento = new TextBox();
            btnInsertar = new Button();
            btnBorrarTodo = new Button();
            btnEliminar = new Button();
            lblItemSeleccionado = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(24, 75);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(194, 334);
            lstElementos.TabIndex = 0;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 57);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Elementos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 57);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "Nuevo Elemento";
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(257, 75);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(125, 23);
            txtNuevoElemento.TabIndex = 3;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(257, 117);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(125, 50);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(257, 229);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(125, 50);
            btnBorrarTodo.TabIndex = 5;
            btnBorrarTodo.Text = "Borrar Todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(257, 173);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 50);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblItemSeleccionado
            // 
            lblItemSeleccionado.AutoSize = true;
            lblItemSeleccionado.Location = new Point(24, 426);
            lblItemSeleccionado.Name = "lblItemSeleccionado";
            lblItemSeleccionado.Size = new Size(38, 15);
            lblItemSeleccionado.TabIndex = 7;
            lblItemSeleccionado.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 460);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 0;
            label4.Text = "label4";
            // 
            // Form11ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 604);
            Controls.Add(label4);
            Controls.Add(lblItemSeleccionado);
            Controls.Add(btnEliminar);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnInsertar);
            Controls.Add(txtNuevoElemento);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstElementos);
            Name = "Form11ColeccionGrafica";
            Text = "Form11ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstElementos;
        private Label label1;
        private Label label2;
        private TextBox txtNuevoElemento;
        private Button btnInsertar;
        private Button btnBorrarTodo;
        private Button btnEliminar;
        private Label lblItemSeleccionado;
        private Label label4;
    }
}