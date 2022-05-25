using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MédiaDeQuatroNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media, nota_exame;
            Console.WriteLine("Média de 4 notas de um aluno...");
            Console.WriteLine("\nDigite a 1ª nota: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite a 2ª nota: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite a 3ª nota: ");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite a 4ª nota: ");
            n4 = double.Parse(Console.ReadLine());
            media = (n1 + n2 + n3 + n4) / 4;
            if (media >= 6) { Console.WriteLine("Média = " + media + " - APROVADO!!"); }
            else if (media >= 4)
            {
                Console.Write("\n\nMédia = " + media + " - EXAME E VOCÊ PRECISA");
                nota_exame = 10 - media;
                Console.WriteLine("DE " + nota_exame + " para passar no exame!!!");
            }
            else { Console.WriteLine("Média = " + media + " - REPROVADO!!"); }
            Console.ReadKey();
        }
    }
}
