using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClinica
{
    public static class Consulta
    {
        public static void mostrarPacientes(List<Paciente> paciente)
        {
            Console.WriteLine("DNI\t  Nombre\tApellido\t   Edad\t   Obra Social");
            Console.WriteLine("------------------------------------------------------------------------");
            foreach (var valor in paciente)
            {
                Paciente.mostrarPaciente(valor);
            }
            Console.WriteLine();
        }

        public static void medicosDisponibles(List<Medico> medico)
        {
            Console.WriteLine("Nombre\t   Apellido\tEspecialidad\tEstado");
            Console.WriteLine("------------------------------------------------------------------------");
            foreach (var valor in medico)
            {
                if (valor.Estado == "sin paciente")
                {
                    Medico.mostrarMedicos(valor);
                }
            }
            Console.WriteLine();
        }

        public static int buscarPaciente(List<Paciente> paciente)
        {
            
            int cont = 0, pos = -1;
            string auxDNI, DNI;
            while(pos == -1)
            {
                Console.Write("ingresar el DNI del paciente: ");
                DNI = Console.ReadLine();

                foreach (var valor in paciente)
                {
                    auxDNI = valor.DNI;


                    if (auxDNI == DNI)
                    {
                        pos = cont;
                        break;
                    }
                    cont++;
                }
                cont = 0;
                
            }
            return pos;
        }

        public static int buscarMedicos(List<Medico> medico)
        {
            int cont = 0, pos = -1;
            string auxNombre, auxApellido, nombreM, apellidoM;
            while(pos == -1)
            {
                Console.Write("ingresa el nombre del Médico: ");
                nombreM = Console.ReadLine();
                Console.Write("ingresa el apellido del Médico: ");
                apellidoM = Console.ReadLine();
                foreach (var valor in medico)
                {
                    //Persona aux = new Persona(valor.Nombre, valor.Apellido);
                    auxNombre = valor.Nombre;
                    auxApellido = valor.Apellido;
                    if (auxNombre == nombreM && auxApellido == apellidoM && valor.Estado == "sin paciente")
                    {
                        pos = cont;
                        break;
                    }
                    cont++;
                }
                if(pos == -1)
                {
                    Console.WriteLine("No se pudo encontrar el Médico, vuelva a ingresar");
                    cont = 0;
                }

            }
            return pos;
        }

        public static void mostrarEspecialidad(List<Especialidad> especialidad)
        {
            Console.WriteLine("Especialidad");
            Console.WriteLine("------------------");
            foreach(var valor in especialidad)
            {
                Especialidad.mostrarEspecialidad(valor);
            }
        }
        public static int buscarEspecialidad(List<Especialidad> especialidad)
        {
            int cont = 0, pos = -1;
            string aux, consulta;
            while(pos == -1)
            {
                Console.Write("seleccione el tipo de consulta: ");
                consulta = Console.ReadLine();
                foreach (var valor in especialidad)
                {
                    aux = valor.tipoConsultas;
                    if (aux == consulta)
                    {
                        pos = cont;
                    }
                    cont++;
                }
                if(pos == -1)
                {
                    Console.WriteLine("Error en la selección de consulta.");
                    cont = 0;
                }
                
            }
            return pos;
        }

        public static void ver_consultas_G(List<Save_Consulta> consulaG)
        {
            //Console.WriteLine("DNI\t   Consulta\tNombre\tApellido");
            //Console.WriteLine("------------------------------------------------------------------------");
            foreach (var valor in consulaG)
            {
                Console.WriteLine("------------------------------------------------------------------------");
                Save_Consulta.mostrarconsultas(valor);
                Console.WriteLine("------------------------------------------------------------------------");

            }
            Console.WriteLine();
        }
        
        public static void mayorConsulta(List<Especialidad> consultas)
        {
            int pos = 0;

            Especialidad mayorC;
            mayorC = consultas[0];
            foreach (var valor in consultas)
            { 
                if(valor.cantConsultas > mayorC.cantConsultas)
                {
                    mayorC = valor;

                }
            }
            //Especialidad.mostrarEspecialidad(mayorC);
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine($"{mayorC.tipoConsultas} : {mayorC.cantConsultas}\n");
            Console.WriteLine("------------------------------------------------------------------------");
        }



    }
}
