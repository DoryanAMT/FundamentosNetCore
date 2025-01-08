using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace FundamentosNetCore
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Apellidos = "Navidad";
            persona.Edad = 25;
            persona.Genero = TipoGenero.Femenino;
            this.lstClases.Items.Add("Indizada " + persona[0]);
            this.lstClases.Items.Add("Indizada " + persona[33]);
            persona.Nacionalidad = Paises.Andorra;

            persona.Domicilio = new Direccion();
            persona.Domicilio.Calle = "Oficina principal de Correos";
            persona.Domicilio.Ciudad = "Napapiiri, Finladia";
            persona.Domicilio.CodigoPostal = 96930;
            this.lstClases.Items.Add(
                "Direccion: " + persona.Domicilio.Calle
                + ", " + persona.Domicilio.Ciudad
                + ", " + persona.Domicilio.CodigoPostal
                );

            this.lstClases.Items.Add(persona.GetNombreCompleto());
            this.lstClases.Items.Add(
                "Nombre: " + persona.Nombre +
                ", Apellidos: " + persona.Apellidos
            );
            this.lstClases.Items.Add("Edad: " + persona.Edad);

        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            //Empleado empleado = new Empleado("Empleado", "Empleado");
            Empleado empleado = new Empleado();
            empleado.Nombre = "Empleado";
            empleado.Apellidos = "Empleado";

            this.lstClases.Items.Add(empleado.GetNombreCompleto());
            this.lstClases.Items.Add("El salario es: " + empleado.GetSalarioMinimo());
            this.lstClases.Items.Add("Vacaciones Empleado: " + empleado.GetDiasVacaciones());
        }

        private void btnDirector_Click(object sender, EventArgs e)
        {
            Director director = new Director();
            director.Nombre = "Director";
            director.Apellidos = "Director";

            this.lstClases.Items.Add(director.GetNombreCompleto());
            this.lstClases.Items.Add("Salario Dire: " +
                director.GetSalarioMinimo());
            this.lstClases.Items.Add("Vaciones Director: " + director.GetDiasVacaciones());

        }
    }
}
