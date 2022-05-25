using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeticao3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("100 primeiros números pares na tela: ");
            while (i <= 200)
            {
                if (i % 2 == 0)
                    
                {
                    
                    Console.WriteLine(i);


                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
