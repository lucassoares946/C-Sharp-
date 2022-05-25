using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            double taxa, aplicacao, meses, valor_acumulado, lucro;
            Console.WriteLine("Rendimento de um deposito");
            Console.WriteLine("Digite o valor da aplicação mensal em reais");
            aplicacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da taxa em %");
            taxa = double.Parse(Console.ReadLine());
            taxa = taxa / 100; //transformando a %
            Console.WriteLine("Digite o numero de meses para saber o rendimento");
            meses = double.Parse(Console.ReadLine());
            valor_acumulado = (Math.Pow(1 + taxa, meses) - 1) * aplicacao / taxa;
            Console.WriteLine("Seu rendimento acumulado é R$ " + Math.Round(valor_acumulado,2));
            lucro = valor_acumulado - aplicacao * meses;
            Console.WriteLine("Lucro é R$ " + Math.Round(lucro, 2));
            Console.ReadKey();
        }
    }
}
