using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividendo = 40;
            int divisorError = 0;
            int divisor = 5;
            //Ejercicio 1)

            dividendo.DivisionCero();
            Console.WriteLine("---------------------------\n");
            //Ejercicio 2)

            dividendo.Division(divisorError);
            dividendo.Division(divisor);
            Console.WriteLine("---------------------------\n");

            //Ejercicio 3)

            try
            {
                Logic.LanzarException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().ToString());
            }
            Console.WriteLine("---------------------------\n");

            //Ejercicio 4)

            try
            {
                Logic.LanzarExceptionPropia("Codigo generico de sobrecarga");
            }
            catch (ExceptionPropia ex)
            {
                Console.WriteLine(ex.GetType().ToString());
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("---------------------------\n");

            Console.ReadKey();

                
        }
    }
}
