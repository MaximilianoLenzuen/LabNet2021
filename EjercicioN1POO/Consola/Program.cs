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
            List<Transporte> listaDeVehiculos = new List<Transporte>();
            Random random = new Random();
            int t = 1;
            int j = 1;
            for (int i = 0; i < 5; i++)
            {
                listaDeVehiculos.Add(new Avion(random.Next(1, 300)));
                listaDeVehiculos.Add(new Automovil(random.Next(1, 300)));
            }

            foreach (var transporte in listaDeVehiculos)
            {
                if (transporte is Avion)
                {
                    Console.WriteLine($"Avion {t}: {transporte.Pasajeros} pasajeros");
                    t++;
                }
            }
            Console.WriteLine("----------------------------");
            foreach (var transporte in listaDeVehiculos)
            {
                if (transporte is Automovil)
                {
                    Console.WriteLine($"Automovil {j}: {transporte.Pasajeros} pasajeros");
                    j++;
                }
            }
            Console.ReadKey();
        }
    }
}
