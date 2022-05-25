using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosTriangulares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, t, aux = 1;
            Console.WriteLine("Números Triangulares - Produto de 3 números consecutivos");
            Console.WriteLine("Digite um nº inteiro positivo: ");
            n = int.Parse(Console.ReadLine());
            t = aux * (aux + 1) * (aux + 2);
            while (t < n)
            {
                aux++;
                t = aux * (aux + 1) * (aux + 2);
            }
            if (t == n) { Console.WriteLine(n + " é TRIANGULAR"); }
            else { Console.WriteLine(n + " NÃO é TRIANGULAR"); }
            Console.ReadKey();
        }
    }
}
