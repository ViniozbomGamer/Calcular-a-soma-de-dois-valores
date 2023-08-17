using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_a_soma_de_dois_valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double número1, número2, resultado;
           
               
            Console.WriteLine("Digite um número:");
            número1 = double.Parse(Console.ReadLine());
            
           
            Console.WriteLine("Digite outro número:");
            número2 = double.Parse(Console.ReadLine());

            resultado = número1 + número2;

            Console.WriteLine("Resultado da some é:" + resultado);
            
            Console.ReadKey();

        }

    }
}
