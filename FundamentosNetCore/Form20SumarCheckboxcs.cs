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
    public partial class Form20SumarCheckboxcs : Form
    {
        List<CheckBox> checkBoxes;
        int suma;


        public Form20SumarCheckboxcs()
        {
            InitializeComponent();
            this.checkBoxes = new List<CheckBox>();
            this.suma = 0;

            foreach (CheckBox chk in this.panel1.Controls)
            {
                checkBoxes.Add(chk);
                chk.Click += SumarNumeros;
            }

        }

        void SumarNumeros(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            int numero = int.Parse(chk.Text);
            this.suma += numero;
            this.txtResultado.Text = numero.ToString();
        }

        private void btnIniciarApp_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            //this.suma = 0;
            //this.txtSuma.Text = suma.ToString();
            ////  RECORREMOS TODOS LOS BOTONES DE MI COLECCION
            //foreach (Button boton in this.botones)
            //{
            //    int numAleatorio = random.Next(1, 99);
            //    boton.Text = numAleatorio.ToString();
            //}
        }
    }
}
