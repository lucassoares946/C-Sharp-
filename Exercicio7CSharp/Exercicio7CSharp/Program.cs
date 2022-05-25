using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, salario2;
            Console.WriteLine("Você está apto para receber um aumento? \nDigite seu salario ! ! !");
            salario = double.Parse(Console.ReadLine());
            salario2 = salario + salario * 0.30;
            if
                (salario <= 500) { Console.WriteLine("Você recebra um aumento de 30% seu novo salário é" + salario2 ); }
            else if
            (salario > 500){ Console.WriteLine("Você não receberá um aumento"); }
            Console.ReadKey();

        }
    }
}
