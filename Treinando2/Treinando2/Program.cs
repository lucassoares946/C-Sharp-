using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinando2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Repetir numero pares que divididos por 2 sobre 5 de 1 até 1000");
            for (i = 1; i <= 1000; i++)
            {

                if (i % 2 == 0) { Console.WriteLine(i); }
                


            }
            Console.ReadKey();
        }
    }
}
        

