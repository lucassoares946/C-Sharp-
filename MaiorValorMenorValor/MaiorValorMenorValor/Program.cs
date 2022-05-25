using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorValorMenorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Relação entre dois números inteiros....");
            Console.WriteLine("Digite o 1º número inteiro: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número inteiro: ");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2) { Console.WriteLine(num1 + " é maior que " + num2); }
            else if (num1 < num2) { Console.WriteLine(num1 + " é menor que " + num2); }
            else { Console.WriteLine("Os dois números são iguais!"); }
            Console.ReadKey();
        }


        }
    }

