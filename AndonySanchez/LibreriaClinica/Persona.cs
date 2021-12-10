namespace LibreriaClinica
{
    public class Persona
    {
        public string Nombre { get; set; } 
        public string Apellido { get; set; }
        
        
        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
    }
    public class Paciente: Persona
    {
        public short Edad { get; set; }
        public string ObraSocial { get; set; }
        public string DNI { get; set; }
        public Paciente(string dni, string nombre, string apellido, short edad, string obraSocial):base(nombre, apellido)
        {
            this.DNI = dni;
            this.Edad = edad;
            this.ObraSocial = obraSocial;
        }

        public static void mostrarPaciente(Paciente valor)
        {
            Console.WriteLine(valor.DNI + "  " + valor.Nombre + "\t" +
                    valor.Apellido + "\t   " + valor.Edad + "\t   " + valor.ObraSocial);
        }

    }
    public class Medico : Persona
    {
        public string Especialidad { get; set; }
        public string Estado = "sin paciente";
        public Medico(string nombre, string apellido, string especialidad): base(nombre, apellido)
        {
            this.Especialidad = especialidad;
        }

        public static void mostrarMedicos(Medico valor)
        {
            Console.WriteLine(valor.Nombre + "\t   " +
                    valor.Apellido + "\t" + 
                    valor.Especialidad + "\t"+
                    valor.Estado);
        }

    }
}