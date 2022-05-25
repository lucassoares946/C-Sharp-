using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeticao3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            Console.WriteLine("100 primeiros números pares na tela: ");
            while (i <= 200)
            {
                Console.WriteLine(i);
                i += 2; //i = i + 2;
            }
            Console.ReadKey();
            


        }
    }
}
