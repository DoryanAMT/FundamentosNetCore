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
            lblIndexSeleccionados = new Label();
            lblItemsSeleccionados = new Label();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            btnInsertar = new Button();
            txtNuevoElemento = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lstElementos = new ListBox();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // lblIndexSeleccionados
            // 
            lblIndexSeleccionados.AutoSize = true;
            lblIndexSeleccionados.Location = new Point(12, 414);
            lblIndexSeleccionados.Name = "lblIndexSeleccionados";
            lblIndexSeleccionados.Size = new Size(111, 15);
            lblIndexSeleccionados.TabIndex = 8;
            lblIndexSeleccionados.Text = "IndexSeleccionados";
            // 
            // lblItemsSeleccionados
            // 
            lblItemsSeleccionados.AutoSize = true;
            lblItemsSeleccionados.Location = new Point(12, 380);
            lblItemsSeleccionados.Name = "lblItemsSeleccionados";
            lblItemsSeleccionados.Size = new Size(111, 15);
            lblItemsSeleccionados.TabIndex = 16;
            lblItemsSeleccionados.Text = "ItemsSeleccionados";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.Location = new Point(245, 127);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 50);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(245, 183);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(125, 50);
            btnBorrarTodo.TabIndex = 14;
            btnBorrarTodo.Text = "Borrar Todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(245, 71);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(125, 50);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
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
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(245, 239);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(125, 50);
            btnSeleccionados.TabIndex = 17;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // Form12ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 450);
            Controls.Add(btnSeleccionados);
            Controls.Add(lblIndexSeleccionados);
            Controls.Add(lblItemsSeleccionados);
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

        private Label lblIndexSeleccionados;
        private Label lblItemsSeleccionados;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Button btnInsertar;
        private TextBox txtNuevoElemento;
        private Label label2;
        private Label label1;
        private ListBox lstElementos;
        private Button btnSeleccionados;
    }
}