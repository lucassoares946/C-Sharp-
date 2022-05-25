using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            double vista = 0, prazo = 0, valor, i;
            String v, p;


            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite v para valores a VISTA e p para a PRAZO");
                v = Console.ReadLine();
                Console.WriteLine("Digite o valor da sua compra ");
                valor = Double.Parse(Console.ReadLine());
                Console.WriteLine("Valor total de todas compras " + (valor + valor * i)); 
                if (v == "v") { vista++;
                    Console.WriteLine("Valor á vista " + valor);
                }
                else{ prazo++;
                    Console.WriteLine("Valor da primeira prestação " + valor / 3);
                    Console.WriteLine("Valor total á prazo " + valor);
                    Console.ReadKey();
                }
            }
        }
    }
}
