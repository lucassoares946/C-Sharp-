using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO1CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;
            Console.WriteLine("Digite suas notas para ver se foi aprovado ou reprovado");
            Console.WriteLine("Digite sua primeira nota");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua segunda nota");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua terceira nota");0
            nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua quarta nota");
            nota4 = double.Parse(Console.ReadLine());
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            if
            (media >= 7)Console.WriteLine("Sua nota é " + media  + " Aprovado");
            else if
            (media < 7)Console.WriteLine("Sua nota é " + media + " Reprovado");
            Console.ReadKey();






        }
    }
}
