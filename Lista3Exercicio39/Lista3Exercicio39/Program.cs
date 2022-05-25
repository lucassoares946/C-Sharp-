using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercicio39
{
    class Program
    {
        static void Main(string[] args)
        {
            double opcao, valor, cod = 1,coda = 0;
            while (cod > 0) {
                Console.WriteLine("Digite seu código");
                cod = double.Parse(Console.ReadLine());
                coda += cod;
                Console.WriteLine("Digite \n1.Poupança \n2,Poupança plus \n3.fundos de renda fixa");
                opcao = double.Parse(Console.ReadLine());

                if (opcao == 1) {
                    Console.WriteLine("Digite o valor para investir");
                    valor = double.Parse(Console.ReadLine());
                    Console.WriteLine("Cliente: " + coda + " Valor investido" + valor + "Juros pagos" + (valor * 1.5));

                }

                if (opcao == 2)
                {
                    Console.WriteLine("Digite o valor para investir");
                    valor = double.Parse(Console.ReadLine());
                    Console.WriteLine("Cliente: " + coda + " Valor investido" + valor + "Juros pagos" + (valor * 2));

                }

                if (opcao == 3)
                {
                    Console.WriteLine("Digite o valor para investir");
                    valor = double.Parse(Console.ReadLine());
                    Console.WriteLine("Cliente: " + coda + " Valor investido" + valor + "Juros pagos" + (valor * 4));


                }
                Console.ReadKey();
            }
        }
    }
}
