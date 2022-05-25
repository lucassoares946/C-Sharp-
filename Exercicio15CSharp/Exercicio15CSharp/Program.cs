using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor,valor2;
            Console.WriteLine("Digite o valor disponivel para investimento: ");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Invista seu dinheiro \n1.Poupança \n2.Fundos de renda fixa");
            valor2 = double.Parse(Console.ReadLine());
            if
                (valor2 == 1) { Console.WriteLine("Na Poupança esse valor irá valer por mês: " + (valor + (valor * 0.03))); }
            else if
                (valor2 == 2) { Console.WriteLine("No Fundo de Renda Fixa esse valor irá valer por mês: " + (valor + (valor * 0.04))); }
            Console.ReadKey();
        }
    }
}
