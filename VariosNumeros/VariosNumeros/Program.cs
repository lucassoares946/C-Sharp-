using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariosNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, soma_multiplos_de_3 = 0, conta_multiplos_de_3 = 0;
            double media;
            Console.WriteLine("Vários Números - Média dos múltiplos de 3...");
            Console.WriteLine("Digite um nº positivo, ou 0 para terminar:");
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                if (num % 3 == 0)
                {
                    conta_multiplos_de_3++; //conta_multiplos_de_3 = conta_multiplos_de_3 + 1;
                    soma_multiplos_de_3 += num;
                    //soma_multiplos_de_3 = soma_multiplos_de_3 + num;
                }
                Console.WriteLine("Digite um nº positivo, ou 0 para terminar:");
                num = int.Parse(Console.ReadLine());
            }
            if (conta_multiplos_de_3 == 0)
            {
                Console.WriteLine("Não foram digitados números múltiplos de 3");
            }
            else
            {
                Console.Clear();
                media = soma_multiplos_de_3 / conta_multiplos_de_3;
                Console.WriteLine("Foram digitados " + conta_multiplos_de_3 + " múltiplos de 3...");
                Console.WriteLine("Média dos múltiplos de 3: " + Math.Round(media, 2));
            }
            Console.ReadKey();
        }
    }
}
