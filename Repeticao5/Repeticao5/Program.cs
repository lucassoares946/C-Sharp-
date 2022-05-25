using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeticao5
{
    class Program
    {
        static void Main(string[] args)
        {
            double i;
            Console.WriteLine("Quadrado dos numeros de 1 a 20");
            for (i =1; i <= 20; i++) 
            {
                Console.WriteLine(i + "² = "+ Math.Pow(i,2));

            }
            Console.ReadKey();
            //double x = 1;
            //Console.WriteLine("Quadrados dos numeros de 1 a 20:");
            //while (x<=20)
            //{ Console.WriteLine(x + "² = " + Math.Pow(x,2));
            //    x++;
            //}
            //Console.ReadKey();
        }
    }
}
