using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClinica
{
    public class Save_Consulta
    {
        public string DniP { get; set; }
        public string TipoConsulta { get; set; }
        public string NombreM { get; set; }
        public string ApellidoM { get; set; }

        public Save_Consulta(string dniP, string tipoConsulta, string nombreM, string apellidoM)
        {
            this.DniP = dniP;
            this.TipoConsulta = tipoConsulta;
            this.NombreM = nombreM;
            this.ApellidoM = apellidoM;
        }

        public static void mostrarconsultas(Save_Consulta consultas)
        {
            Console.WriteLine($"DNI del paciente: {consultas.DniP}\n" +
                              $"Tipo de consulta: {consultas.TipoConsulta}\n" +
                              $"Médico: {consultas.NombreM} {consultas.ApellidoM}\n");
        }
     }
}
