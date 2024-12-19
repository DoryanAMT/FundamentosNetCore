namespace FundamentosNetCore
{
    partial class Form14TiendaDeProductos
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
            btnNuevo = new Button();
            txtProducto = new TextBox();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            lstTienda = new ListBox();
            label2 = new Label();
            label3 = new Label();
            btnSeleccion = new Button();
            btnTodos = new Button();
            lstAlmacen = new ListBox();
            btnBajar = new Button();
            btnSubir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(23, 78);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 23);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(23, 38);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(23, 107);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(23, 136);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(100, 23);
            btnBorrarTodo.TabIndex = 4;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.Location = new Point(140, 38);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(158, 214);
            lstTienda.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 20);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 6;
            label2.Text = "Tienda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(385, 20);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 7;
            label3.Text = "Almacén";
            // 
            // btnSeleccion
            // 
            btnSeleccion.Location = new Point(304, 78);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(75, 23);
            btnSeleccion.TabIndex = 8;
            btnSeleccion.Text = "Seleccion";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(304, 136);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(75, 23);
            btnTodos.TabIndex = 9;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.Location = new Point(385, 38);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(158, 214);
            lstAlmacen.TabIndex = 10;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(549, 136);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(75, 23);
            btnBajar.TabIndex = 12;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(549, 78);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(75, 23);
            btnSubir.TabIndex = 11;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            // 
            // Form14TiendaDeProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 271);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(lstAlmacen);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstTienda);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(txtProducto);
            Controls.Add(btnNuevo);
            Controls.Add(label1);
            Name = "Form14TiendaDeProductos";
            Text = "Form14TiendaDeProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnNuevo;
        private TextBox txtProducto;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private ListBox lstTienda;
        private Label label2;
        private Label label3;
        private Button btnSeleccion;
        private Button btnTodos;
        private ListBox lstAlmacen;
        private Button btnBajar;
        private Button btnSubir;
    }
}