using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio19Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            double prestacoestotal, prestacoespagas, valorprestacao, totalpago, saldo;
            Console.WriteLine("Digite o numero total de prestações");
            prestacoestotal = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de prestações pagas");
            prestacoespagas = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da prestação");
            valorprestacao = double.Parse(Console.ReadLine());
            totalpago = prestacoespagas * valorprestacao;
            saldo = (prestacoestotal * valorprestacao) - totalpago;
            Console.WriteLine("Você pagou " + prestacoespagas + " prestações no valor de R$ " + totalpago + " faltam serem pagas " + (prestacoestotal - prestacoespagas) + " prestações com valor total de R$ "+ saldo );
            Console.ReadKey();

        }
    }
}
