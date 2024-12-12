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
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnCompobarIsbn_Click(object sender, EventArgs e)
        {
            string isbn = this.txtIsbn.Text;
            int suma = 0;

            if (isbn.Length != 10)
            {
                this.lblResultado.Text = "El ISBN debe de ser de 10 caracteres";
            }
            else
            {
                for (int i = 0; i < isbn.Length; i++)
                {
                    char caracter = isbn[i];

                    int numero = Convert.ToInt32(caracter.ToString());

                    suma += numero * (i + 1);

                }

                if (suma % 11 == 0)
                {
                    this.lblResultado.Text = "ISBN Correcto";
                }
                else
                {
                    this.lblResultado.Text = "ISBN Incorrecto";
                }
            }

            
        }
    }
}
