using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2,i,digite;
            Console.WriteLine("Digite o número que deseja saber a taboada");
            digite = int.Parse(Console.ReadLine());
            for (i = 1; i < 11; i++)
            {
                Console.WriteLine(digite * i);
            }


                Console.ReadKey();
            }
        }
    }

