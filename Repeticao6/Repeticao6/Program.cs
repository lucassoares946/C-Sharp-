using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeticao6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, soma = 0;
            Console.WriteLine("Numeros de 1 a 200: ");
            for(i = 1; i <= 200; i++)
            {
                Console.WriteLine(i);
                soma += i;//soma = soma + i;
            }
            Console.WriteLine("A soma de 1 até 200 vale " + soma);
            Console.ReadKey();
        }
    }
}
