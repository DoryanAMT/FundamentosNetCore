using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director: Empleado
    {
        public Director() 
        {
            Debug.WriteLine("Constructor DIRECTOR");
            //un director cobra 200€ más que un empleado
            this.salarioMinimo += 200;
        }
        //METODO SOBRESCRITO
        // sin la palabra override no pobremos sobrescribir el metodo
        public new int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVaciones() DIRECTOR");
            int vacionesEmpleado = base.GetDiasVacaciones();
            return vacionesEmpleado + 8;
        }
        //metodo implementado
        public int GetDiasVacaciones(int extras) 
        {
            return this.GetDiasVacaciones() + extras;
        }
    }
}
