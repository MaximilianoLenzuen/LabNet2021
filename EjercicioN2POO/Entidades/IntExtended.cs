using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class IntExtended
    {
        public static int DivisionCero(this int numero)
        {
            try
            {
                return numero / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            finally
            {
                Console.WriteLine("La operacion ha finalizado!!");
            }
        }

        public static int Division(this int dividendo, int divisor)
        {
            try
            {
                int resultado;
                resultado = dividendo / divisor;
                Console.WriteLine($"El resultado es: {resultado}");
                return resultado;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Intentaste dividir por zero??!! --> 15 días más de cuarentena!");
                Console.WriteLine(ex.Message);
                return 0;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Seguro ingreso una letra o no ingreso nada!");
                return 0;
            }
        }


    }
}
