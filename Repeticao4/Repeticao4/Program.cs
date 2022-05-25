using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeticao4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            Console.WriteLine("Numeros multiplos de 5, 1 entre 600");
           while (i <=600)
                {
                Console.WriteLine(i);
                i += 5;
               
            }
            Console.ReadKey();

        }
    }
}
