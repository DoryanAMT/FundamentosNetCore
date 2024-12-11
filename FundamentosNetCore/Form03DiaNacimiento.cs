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
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnCalcularDiaNacimiento_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int anio = int.Parse(txtAnio.Text);

            if (mes == 1)
            {
                mes = 13;
                anio -= 1;
            }
            else if (mes == 2)
            {
                mes = 14;
                anio --;
            }


            int diaNacimiento = calcularDianNacimiento(
                int.Parse(txtDia.Text),
                int.Parse(txtMes.Text),
                int.Parse(txtAnio.Text));

            if (diaNacimiento == 0)
            {
                this.lblDiaSemana.Text = "Sábado";
            }else if (diaNacimiento == 1)
            {
                this.lblDiaSemana.Text = "Domingo";
            }
            else if (diaNacimiento == 2)
            {
                this.lblDiaSemana.Text = "Lunes";
            }
            else if (diaNacimiento == 3)
            {
                this.lblDiaSemana.Text = "Martes";
            }
            else if (diaNacimiento == 4)
            {
                this.lblDiaSemana.Text = "Miércoles";
            }
            else if (diaNacimiento == 5)
            {
                this.lblDiaSemana.Text = "Jueves";
            }
            else if (diaNacimiento == 6)
            {
                this.lblDiaSemana.Text = "Viernes";
            }
            else
            {
                this.lblDiaSemana.Text = "Ha habido un problema";
            }

            
        }

        public int calcularDianNacimiento(int dia, int mes, int anio)
        {
            
            int resultadoMes = 0;
            int resultadoAnio4 = 0;
            int resultadoAnio100 = 0;
            int resultadoAnio400 = 0;
            int division = 0;
            int suma = 0;
            int resultado = 0;
            resultadoMes = ((mes +1) * 3)/5;
            resultadoAnio4 = anio / 4;
            resultadoAnio100 = anio / 100;
            resultadoAnio400 = anio / 400;
            suma = dia + (mes * 2) + anio + resultadoMes + resultadoAnio4 - resultadoAnio100 + resultadoAnio400 + 2;
            division = suma / 7;

            resultado = suma - (division * 7);

            return resultado;

        }
    }
}
