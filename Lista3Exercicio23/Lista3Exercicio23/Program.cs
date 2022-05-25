using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade, otimo = 0, bom = 0, regular = 0, i,nota,nota3 = 0;
            for (i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite sua idade: ");
                idade = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite sua opinião sobre o filme: \n3.Ótimo \n2.Bom \n1.Regular ");
                nota = double.Parse(Console.ReadLine());

                if (nota == 3) 
                {
                    otimo++;
                    nota3 += nota;
                }

                if (nota == 1)
                {
                    regular++;
                   
                }

                if (nota == 2)
                {

                    bom++;
                    
                }

            }
            Console.WriteLine("Média das idades dos que acharam Ótimo: " + nota3 / i);
            Console.WriteLine("Quantidade de pessoas que acharam Regular: " + regular);
            Console.WriteLine("Porcentagem de pessoas que acharam Bom: " + bom / 100 + "%");
            Console.ReadKey();
        }
    }
}
