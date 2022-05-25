using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeticao10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Números - entre 1000 e 2000 - que, quando divididos por 11");
            Console.WriteLine("dão resto igual a 5");
            for (i = 1000; i <= 2000; i++)
            {
                if (i % 11 == 5) { Console.WriteLine(i); }
            }
            Console.ReadKey();
        }
    }
}
