using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeticao2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            Console.WriteLine("Números de 100 a 1 na tela: ");
            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;//i = i - 1;
            }
            Console.ReadKey();
        }
    }
}
