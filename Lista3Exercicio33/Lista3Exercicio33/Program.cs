using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, numa = 0,numb = 0,num2,num3,peso,peso2,peso3;
            Console.WriteLine("1.Média aritmética \n2.Média ponderada \n3.Sair");
            num = double.Parse(Console.ReadLine());
            if(num == 1)
            {
                Console.WriteLine("Digite a primeira nota");
                num = double.Parse(Console.ReadLine());
                numa += num;
                Console.WriteLine("Digite a segunda nota");
                num = double.Parse(Console.ReadLine());
                numa += num;
                Console.WriteLine("Média: " + numa / 2);
               
            }
            
            if(num == 2)
            {
                Console.WriteLine("Digite sua nota");
                num = double.Parse(Console.ReadLine());
               // numa += num;
                Console.WriteLine("Digite peso");
                peso = double.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite sua nota");
                num2 = double.Parse(Console.ReadLine());
               // numa += num2;
                Console.WriteLine("Digite peso");
                peso2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite sua nota");
                num3 = double.Parse(Console.ReadLine());
                numa += num3 + num2 + num;
                Console.WriteLine("Digite peso");
                peso3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Média ponderada: " +( ((peso * num) + (peso2 * num2) + (peso3 * num3)) / numa));

            }

            if(num == 3)
            {
                Console.WriteLine("Programa Encerrado");
            }

            if(num != 1 & num != 2 & num != 3)
            {

                Console.WriteLine("Opção inválida!");
            }

            Console.ReadKey();
        }

    }
}

