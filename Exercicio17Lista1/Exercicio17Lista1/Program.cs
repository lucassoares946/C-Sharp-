using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            double aval1, aval2, aval3, aval4, media;
            Console.WriteLine("Média ponderada de quatro notas");
            Console.WriteLine("Digite a 1 nota do aluno (peso 2)");
            aval1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 1 nota do aluno (peso 4)");
            aval2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 1 nota do aluno (peso 6)");
            aval3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 1 nota do aluno (peso 8)");
            aval4 = double.Parse(Console.ReadLine());
            media = (aval1 * 2 + aval2 * 4 + aval3 * 6 + aval4 * 8)/(2 + 4 + 6 + 8);
            Console.WriteLine("A média ponderada é " + Math.Round(media,2));
            Console.ReadKey();

        }
    }
}
