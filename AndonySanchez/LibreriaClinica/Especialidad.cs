using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClinica
{
    public class Especialidad
    {
        public string tipoConsultas { get; set; }
        public int cantConsultas { get; set; }

        public Especialidad(string tipoconsulta, int cantConsultas = 0)
        {
            this.tipoConsultas = tipoconsulta;
            this.cantConsultas = cantConsultas;
        }

        public static void mostrarEspecialidad(Especialidad especialidad)
        {
            Console.WriteLine(especialidad.tipoConsultas);
        }
        
    }
}
