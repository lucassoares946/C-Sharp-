using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, r, s, d;
            Console.WriteLine("Calculo de expressão");
            Console.WriteLine("Digite o valor de A");
            a = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Digite o valor de B");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C");
            c = double.Parse(Console.ReadLine());
            r = Math.Pow(a + b, 2);
            s = Math.Pow(b + c, 2);
            d = (r + s) / 2;
            Console.WriteLine("O resultado da expressão é: " + d);
            Console.ReadKey();
            
        }
    }
}
