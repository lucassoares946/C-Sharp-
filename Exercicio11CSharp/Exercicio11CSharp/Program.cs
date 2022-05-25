using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, salario2,salario3,salario4,salario5,salario6,salario7,salario8;
            Console.WriteLine("Calcule seu aumento");
            salario = double.Parse(Console.ReadLine());
            salario2 = (salario * 0.15) + salario;
            salario7 = (salario * 0.10) + salario;
            salario8 = (salario * 0.5) + salario;
            salario3 = salario * 0.15;
            salario4 = salario * 0.10;
            salario5 = salario * 0.5;
            salario6 = 0;

            if
                (salario <= 300) { Console.WriteLine("Seu aumento é de: " + salario3 + " Seu novo salario é:  " + salario8); }
            else if
                (salario > 300 && salario < 600) { Console.WriteLine("Seu aumento é de: " + salario5 + " Seu novo salario: " + salario7); }
            else if
                (salario > 600 && salario <= 900) { Console.WriteLine("Seu aumento é de: " + salario4 + " Seu novo salario: " + salario7); }
            else if
                (salario > 900) { Console.WriteLine("Seu aumento é de: " + salario6 + " Seu novo salario: " + salario); }

            Console.ReadKey();

        }
    }
}
