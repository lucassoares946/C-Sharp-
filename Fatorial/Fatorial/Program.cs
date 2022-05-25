using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, fat = 1, i;
            Console.WriteLine("Fatorial de um nº positivo:");
            Console.WriteLine("Digite um nº inteiro positivo:");
            num = double.Parse(Console.ReadLine());
            if (num == 0) { Console.WriteLine("0! = 1"); }
            else if (num > 0)
            {
                for (i = num; i >= 1; i--)
                {
                    fat *= i;//fat = fat * i;
                }
                Console.WriteLine(num + "! = " + fat);
            }
            else { Console.WriteLine("Não existe fatorial de nº negativo!"); }

            Console.ReadKey();
        }
    }
}
