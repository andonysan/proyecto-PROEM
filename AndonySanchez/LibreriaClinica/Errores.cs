using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClinica
{
    public static  class Errores
    {
        public static int opciones()
        {
            int option = 0;
            while (option == 0)
            {
                try
                {
                    Console.Write("Ingresar una opción: ");
                    option = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No se selecciono ninguna opción vuelve a intentarlo");
                }
                
            }
            return option;
            
        }

    }
}
