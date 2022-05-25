using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, cal;
            Console.WriteLine("Calculadora: \n Digite o primeiro número:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Calculadora: \n Digite o segundo número:");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Faça o calculo de: \n 1.Média \n 2.Diferença \n 3.Produto \n 4.Divisão");
            cal = double.Parse(Console.ReadLine());
            if
                (cal == 1) { Console.WriteLine("A média é" + (num1 + num2) / 2); }
            else if
               (cal == 2) { Console.WriteLine("A diferença é" + (num1 - num2)); }
            else if
                (cal == 3) { Console.WriteLine("O produto é" + (num1 * num2)); }
            else if
                (cal == 4) { Console.WriteLine("A divisão é" + (num1 / num2)); }
            Console.ReadKey();




        }
    }
}
