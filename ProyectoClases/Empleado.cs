using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado: Persona
    {
        protected int salarioMinimo {  get; set; }
        public Empleado()
        {
            Debug.WriteLine("Constructor EMPLEADO vacío");
            this.salarioMinimo = 1400;
        }
        public Empleado(string nombre, string apellidos)
        {
            Debug.WriteLine("Constructor EMPLEADO 2 parámetros");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
        // sin la palabra virtual no podremos sobrescribirlo con override en la clase heredada
        public int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 22;
        }
        public int GetSalarioMinimo()
        {
            return this.salarioMinimo;
        }
    }
}
