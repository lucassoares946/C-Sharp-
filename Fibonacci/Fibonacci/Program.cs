using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, anterior = 0, atual = 1, proximo;
            Console.WriteLine("Série de Fibonacci: 1, 1, 2, 3, 5, 8, 13, .....");
            Console.WriteLine("Digite o nº de termos da série, que deseja imprimir na tela:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Série de Fibonacci com " + n + " termos:");
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(atual);
                proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }
            Console.ReadKey();
        }
    }
}
