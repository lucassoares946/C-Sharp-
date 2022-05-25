using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saque
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            int saque, n200, n100, n50, n20, n10, n5, n2, n1;
            Console.WriteLine("Saque num Caixa Eletrônico - Metodista");
            Console.WriteLine("Digite o saque, em R$: ");
            saque = int.Parse(Console.ReadLine());
            //Processamento
            n200 = saque / 200;
            n100 = (saque % 200) / 100;
            n50 = ((saque % 200) % 100) / 50;
            n20 = (((saque % 200) % 100) % 50) / 20;
            n10 = ((((saque % 200) % 100) % 50) % 20) / 10;
            n5 = (((((saque % 200) % 100) % 50) % 20) % 10) / 5;
            n2 = ((((((saque % 200) % 100) % 50) % 20) % 10) % 5) / 2;
            n1 = ((((((saque % 200) % 100) % 50) % 20) % 10) % 5) % 2;
            //Saída
            Console.WriteLine("\n\nO saque de R$" + saque + " nos fornece: \n");
            Console.Write(n200 + " notas de R$200, " + n100 + " notas de R$100, ");
            Console.Write(n50 + " notas de R$50, " + n20 + " notas de R$20, ");
            Console.Write(n10 + " notas de R$10, " + n5 + " notas de R$5, ");
            Console.Write(n2 + " notas de R$2 e " + n1 + " moedas de R$1... ");
            Console.ReadKey();




        }
    }
}
