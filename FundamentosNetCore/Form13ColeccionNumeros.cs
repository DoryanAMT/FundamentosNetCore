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
    public partial class Form13ColeccionNumeros : Form
    {
        public Form13ColeccionNumeros()
        {
            InitializeComponent();

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.lstNumeros.Items.Clear();
            for (int i = 0; i <= 10; i++)
            {
                int newRandom = random.Next(0, 10);
                this.lstNumeros.Items.Add(newRandom);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int sumaPares = 0;
            int sumaImpares = 0;
            foreach (int num in this.lstNumeros.Items)
            {
                suma += num;
                if (num % 2 == 0)
                {
                    sumaPares += num;
                }
                else
                {
                    sumaImpares += num;
                }
            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = sumaPares.ToString();
            this.txtImpares.Text = sumaImpares.ToString();


        }
    }
}
