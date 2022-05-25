using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, i,t = 1;
            Console.WriteLine("Digite um valor: ");
            n = double.Parse(Console.ReadLine());
 
            if (n != 0)
            {




                for (i = 0; i < n; i++)
                {
                    t *= (n - i);

                }
                Console.WriteLine(t);


                Console.ReadKey();

                
            }

            
        }
    }
}