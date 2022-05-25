using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Digite qual tabuada deseja vizualizar 1 á 10");
            n = int.Parse(Console.ReadLine());
            for (i = i; i <= 10; i++)
            {
                if (n < 10) Console.WriteLine("Tabuada do " + n + "  " + (n * i));}
            Console.ReadKey();
            }
          
        }
    }

