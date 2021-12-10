using System;
using LibreriaClinica;

namespace ConsoleClinica
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Paciente> pacientes = new List<Paciente>() {
                new Paciente("94844267", "Andrea ", "Sanabria Payano", 47, "No Tiene"),
                new Paciente("94561364", "Aldair ", "Sanchez Acevedo", 22, "Cobertura Basica"),
                new Paciente("94677243", "Milagros", "Echabaudes Guia", 20, "Cobertura Completa"),
                new Paciente("93456328", "Neyser", "Sanchez Acebedo", 26, "No Tiene")
            };

            List<Medico> medicos = new List<Medico>()
            {
                new Medico("Alfredo", "Suarez", "Cardiologia"),
                new Medico("Rodrigo", "Perez", "Dermatología"),
                new Medico("Luis", "Pacheco", "Ginecologia"),
                new Medico("Miguel", "Morales", "Neorocirugía"),
                new Medico("Arturo", "Rondón", "Nutrición"),
                new Medico("Michel", "Mendoza", "Oftalmología")
            };

            List<Especialidad> especialidad = new List<Especialidad>()
            {
                new Especialidad("Cardiologo"),
                new Especialidad("Traumotología"),
                new Especialidad("Cirugia"),
                new Especialidad("Ginecología"),
                new Especialidad("Pediatría"),
                new Especialidad("Nutrición"),
                new Especialidad("Medicina"),
                new Especialidad("Sexología")
            };

            List<Save_Consulta> guardarConsultas = new List<Save_Consulta>();
            List<Paciente> pacientesAtendidos = new List<Paciente>();
                
            while (true)
            {
                Console.WriteLine($"1. Lista de Paciente\n" +
                $"2. Lista de Medicos Disponibles\n" +
                $"3. Asignar una Consulta\n"+
                $"4. Ver consultas realizadas\n"+
                $"5. Especialidad con más consultas\n" +
                $"5. Salir\n");
                
                int opcion = Errores.opciones();
                Console.WriteLine();
                ///<sumary>
                ///opciones para ingresar a cada menú, dependiendo de lo se elija
                ///</sumary>
                if(opcion == 1)
                {
                    Consulta.mostrarPacientes(pacientes);

                }
                if (opcion == 2)
                {
                    Consulta.medicosDisponibles(medicos);

                }
                if (opcion==3)
                {
                    int posP;

                    Consulta.mostrarPacientes(pacientes);
                    posP = Consulta.buscarPaciente(pacientes);

                    if(posP >= 0)
                    {
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("Se seleccionó correctamente el paciente");
                        Console.WriteLine("-----------------------------------------------------------------");
                    }
                   
                    int posE;
                    Consulta.mostrarEspecialidad(especialidad);
                    
                    posE = Consulta.buscarEspecialidad(especialidad);
                    if(posE >= 0)
                    {
                        Console.WriteLine("-----------------------------------------------------------------");
                        Console.WriteLine("se seleccionó correctamente la consulta");
                        Console.WriteLine("-----------------------------------------------------------------");
                    }
                    
                    int posM;

                    Consulta.medicosDisponibles(medicos);
                    posM = Consulta.buscarMedicos(medicos);
                    medicos[posM].Estado = "con paciente";
                    if (posM >= 0)
                    {
                        Console.WriteLine("Se selecciono el médico, correctamente\n");
                    }


                    if (posP >= 0 && posE >= 0 && posM >= 0)
                    {
                        guardarConsultas.Add(new Save_Consulta(pacientes[posP].DNI, especialidad[posE].tipoConsultas, medicos[posM].Nombre, medicos[posM].Apellido));
                        Console.WriteLine("Consulta finalizada\n");
                        pacientesAtendidos.Add(pacientes[posP]);
                        pacientes.Remove(pacientes[posP]);
                        especialidad[posE].cantConsultas += 1; 
                    }
                    
                }
                if (opcion == 4)
                {
                    Console.WriteLine("Consultas Finalizadas: ");
                    Consulta.ver_consultas_G(guardarConsultas);
                }
                if (opcion == 5)
                {
                    Consulta.mayorConsulta(especialidad);
                }
                if(opcion == 6)
                {
                    break;
                }
               
            }

            
        }
    }
}
