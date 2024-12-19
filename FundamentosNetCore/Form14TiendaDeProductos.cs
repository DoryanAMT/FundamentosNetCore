using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form14TiendaDeProductos : Form
    {
        public Form14TiendaDeProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode =
                SelectionMode.MultiExtended;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string nuevoProducto = this.txtProducto.Text.ToUpper();
            if (!this.lstTienda.Items.Contains(nuevoProducto))
            {
                this.lstTienda.Items.Add(nuevoProducto);
            }
            else
            {
                foreach (int num in this.lstTienda.Items)
                {
                    this.lstTienda.Focus();
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numSeleccionados = this.lstTienda.SelectedIndices.Count;
            for (int i = numSeleccionados - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //  TENEMOS UN METODO LLAMADO AddRange  EN LA COLECCIONES
            //  QUE PERMITEN AGREGAR UN CONJUNTO A LA VEZ
            this.lstAlmacen.Items.AddRange(this.lstTienda.Items);
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            this.lstAlmacen.Items.AddRange(this.lstTienda.Items);
        }
    }
}
