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
    public partial class Form17ListDelegados : Form
    {
        //  DECLARAMOS UN VARIABLE CONTADOR
        int contador;
        List<Button> botones;

        //  SIEMPRE DEBEMOS INICIALIZAR LAS VARIABLES DENTRO DEL CONSTRUCTOR
        //  HACERLO FUERA DE EL ES UNA MALA PRACTICA
        public Form17ListDelegados()
        {
            InitializeComponent();
            this.contador = 0;
            this.botones = new List<Button>();
            //this.button1.Click += botonPulsado;
            // SI ALMACENAMOS TODOS LOS OBJETOS DENTRO
            //  DE LA COLECCION, PODEMOS HACER LA ACCION
            //  DELEGADA CON UN FOREACH
            //this.botones.Add(this.button1);
            //this.botones.Add(this.button2);
            ////   SI QUEREMOS QUE UN BOTON NO CAMBIAR LO SACAREMOS DEL ARRAYLIST
            ////this.botones.Add(this.button3);
            //this.botones.Add(this.button4);

            //  CON LA COLECCION CONTROLS PODRESMO REOCRRER UN CONJUNTO
            //  DE OBJETOS Y RELLENAR DINAMICAMENTE NUESTRAS COLECCIONES
            //  PROPIAS

            foreach (Control miControl in this.Controls)
            {
                //DEBEMOS PREGUNTAR POR LOS BOTONES
                if (miControl is Button)
                {
                    this.botones.Add((Button)miControl);
                }
            }

            foreach (Button boton in this.botones)
            {
                boton.Click += botonPulsado;       
            }
        }

        void botonPulsado(object sender, EventArgs e)
        {
            this.contador += 1;
            this.txtContador.Text = this.contador.ToString();
            //  sender  ES EL OBJETO QUE REALIZA LA LLAMADA
            Button miBoton = (Button)sender;
            miBoton.BackColor = Color.Yellow;
        }
    }
}
