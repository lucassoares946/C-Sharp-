using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio21Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            double prestacaonova, prestacao, juros, atraso;
            Console.WriteLine("Calcule o juros da sua conta \nDigite o valor da Prestação:");
            prestacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a taxa de juros");
            juros = double.Parse(Console.ReadLine());
            juros = juros / 100;
            Console.WriteLine("Dias atrasados");
            atraso = double.Parse(Console.ReadLine());
            prestacaonova = prestacao + (prestacao * juros * atraso);
            Console.WriteLine("O valor da prestação em atraso é " + prestacaonova);
            Console.ReadKey();

        }
    }
}
