using System;
using System.Collections;
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
    public partial class Form16ArrayList : Form
    {
        public Form16ArrayList()
        {
            InitializeComponent();

            //  DECLARAMOS UN COLECCION DE Button
            List<Button> botones = new List<Button>();
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            //  EL OBJETO ES RECONOCIBLE POR SU TIPADO T
            botones[0].BackColor = Color.AliceBlue;
            //  VENTAJA TENEMOS ERRORES DE COMPILACION
            //botones.Add(this.textBox1); (da error)

            //  VAMOS A CREAR UNA COLECCION NO TIPADA
            //  Y ALMACENAR LOS BOTONES
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            //  AÑADIMOS UN TEXTBOX
            coleccion.Add(this.textBox1);
            //  SI INTENTAMOS ACCEDER A UN ELEMENTO DE LA COLECCION
            //  Y A SUS PROPIEDADES, NO PODEMOS SIN HACER CASTING
            ((Button)coleccion[0]).BackColor = Color.Yellow;
            //  MEDIANTE LA ABSTRACCION, PODEMOS CONVERTIR Y RECORRER
            //  TODOS LOS OBJETOS DENTRO DE BUCLES DE REFERENCIA
            //foreach (Button boton in coleccion)
            //{
            //    boton.BackColor = Color.LightBlue;
            //}

            //  SI TENGO OBJETOS DE CLASES DISTINTAS, DEBEMOS
            //  ABSTRAERNOS
            foreach (Control control in coleccion)
            {
                control.BackColor = Color.LightBlue;
                //  LA CLASE TEXTBOX CONTIENE UN METODO Paste()
                //  PARA PEGAR EL CONTENIDO DEL PORTAPAPELES
                //  EL INTERIOR DEL CONTROL
                //  DEBEMOS PREGUNTAR POR EL TIPO DE CONTROL

                // PARA PODER ACCEDER AL METODO DEL TEXTBOX PREVIAMENTE
                //  HAY QUE CASTEAR LA VARIABLE DEL ARRAYLIST
                if (control is TextBox)
                {

                    ((TextBox)control).Paste();
                }
            }


            this.button1.Click += MetodoDelegado;

            

        }

        void MetodoDelegado(object sender, EventArgs e)
        {

        }
    }
}
