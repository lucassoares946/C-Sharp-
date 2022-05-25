using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Qual numero é menor? \n Digite o primeiro número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            num2 = int.Parse(Console.ReadLine());
            if
            (num1 > num2) Console.WriteLine("O número  " + num1 + "  é maior " );
            else if
            (num2 > num1) Console.WriteLine("O número " + num2 + "  é maior " );
            Console.ReadKey();



        }
    }
}
