using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public enum TipoGenero { Masculino = 0, Femenino = 1}
    public enum Paises { España, Alemania, Andorra, Tabarnia, Francia}
    public class Persona
    {
        public Persona()
        {
            Debug.WriteLine("Constructor PERSONA vacío");
            this.Domicilio = new Direccion();
        }

        public Persona(string nombre, string apellidos)
        {
            Debug.WriteLine("Constructor PERSONA 2 parámetros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

        #region PROPIEDADES

        private string _DescripcionThis;
        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set { 
                Random random = new Random();
                int aleat = random.Next(1, 20);
                this._DescripcionThis = "Descripción  " + aleat;
            }
        }

        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }
        private TipoGenero _Genero;
        public TipoGenero Genero
        {
            get { return _Genero; }
            set
            {
                if (value != TipoGenero.Femenino &&
                    value != TipoGenero.Femenino)
                {
                    throw new Exception("Valor de género incorrecto");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        //public TipoGenero Genero { get; set; }
        public Paises Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        // CREAMOS UN CAMPO PRIVADO DE LA EDAD
        private int _Edad;
        public int Edad
        {
            get { return this._Edad; }
            set
            {
                //  DEBEMOS COMPROBAR EL VALOR DE LA EDAD
                //  QUE VIENE EN value
                if (value < 0)
                {
                    //  SI NOS DAN UN VALOR INCORRECTO
                    //  ERROR SILENCIOSO
                    //this._Edad = 0;
                    //  LANZAMOS UNA EXCEPCION
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    //  TODO CORRECTO
                    this._Edad = value;
                }
            }
        }
        #endregion

        #region METODOS
        //  METOD PARA DEOLVER UN NOMBRE COMPLETO
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }
        //  METOD PARA DEVOLVER APELLIDOS Y NOMBRE
        public string GetNombreCompletoDelReves()
        {
            return this.Apellidos + " " + this.Nombre;
        }
        //  METODO PARA DOVOLVER NOMBRE Y APELLIDOS EN MATUSUCLA
        public string GetNombreApellidosMayuscula ()
        {
            return (this.Nombre + " " + this.Apellidos).ToUpper();
        }
        //  METODO PARA DOVOLVER NOMBRE Y APELLIDOS EN MINUSCULAR
        public string GetNombreApellidosMinuscula()
        {
            return (this.Nombre + " " + this.Apellidos).ToLower();
        }

        #endregion


    }
}
