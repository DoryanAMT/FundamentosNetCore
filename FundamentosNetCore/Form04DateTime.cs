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
    public partial class Form04DateTime : Form
    {
        public Form04DateTime()
        {
            InitializeComponent();
            //  AL INICAR LA CLASE (CONSTRUCTOR)
            //  ESCRIBIREMOS LA FECHA ACTUAL
            this.txtFechaActual.Text = DateTime.Now.ToString();

        }

        private void chkCambiarFormato_CheckedChanged(object sender, EventArgs e)
        {
            //  RECUPERAMOS LA FECHA DE LA CAJA
            //  RECORDAR PARSEAR LOS DATOS DE TIPO PRIMITIVOS (WRAPERS)
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            if (this.chkCambiarFormato.Checked == true)
            {
                this.txtFechaActual.Text = fecha.ToLongDateString();
            }
            else
            {
                this.txtFechaActual.Text = fecha.ToShortDateString();
            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            int incrementar = int.Parse(this.txtIncremento.Text);
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);

            if (this.rdbDias.Checked == true)
            {
                fecha = fecha.AddDays(incrementar);
            }else if (this.rdbAnios.Checked == true)
            {
                fecha = fecha.AddYears(incrementar);
            }
            else
            {
                fecha = fecha.AddMonths(incrementar);
            }

            this.txtNuevaFecha.Text = fecha.ToString();
        }
    }
}
