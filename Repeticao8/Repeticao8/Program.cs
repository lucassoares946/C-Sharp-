using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeticao8
{
    class Program
    {
        static void Main(string[] args)
        {
            double pol;
            Console.WriteLine("Conversão de Polegadas e Centimetros -1 a 40 pol.");
            for(pol = 1; pol <= 40; pol++)
            {
                Console.WriteLine(pol + " polegadas = " + pol * 2.54 + "Centimetros");
            }
            Console.ReadKey();
        }
    }
}
