using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FundamentosNetCore
{
    public partial class Form02PosicionColores : Form
    {
        public Form02PosicionColores()
        {
            InitializeComponent();
        }

        private void btnCambiarPosicionBoton_Click(object sender, EventArgs e)
        {
            int posicionX = int.Parse(this.txtPosicionX.Text);
            int posicionY = int.Parse(this.txtPosicionY.Text);

            this.btnCambiarPosicionBoton.Location = new Point(posicionX, posicionY);
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            int colorRojo = int.Parse(this.txtColorRojo.Text);
            int colorAzul = int.Parse(this.txtColorAzul.Text);
            int colorVerde = int.Parse(this.txtColorVerde.Text);

            if (colorRojo < 0 || colorRojo > 255)
            {
                MessageBox.Show("EL valor rojo debe estar entre 0 y 255",
                    "Titulo",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Question);
            }else if (colorAzul < 0 || colorAzul > 255)
            {
                MessageBox.Show("EL valor azul debe estar entre 0 y 255",
                    "Titulo",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Question);
            }
            else if (colorRojo < 0 || colorRojo > 255)
            {
                MessageBox.Show("EL valor rojo debe estar entre 0 y 255",
                    "Titulo",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Question);
            }else
            {
                this.BackColor = Color.FromArgb(colorRojo,colorVerde, colorAzul);
            }

            
        }

        
    }
}
