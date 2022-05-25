using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercicio37
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 1,soma2;
            while(soma >= 1)
            {
                Console.WriteLine("Digite \n1.Adição \n2.Subtração \n3.Multiplicação \n4.Divisão");
                soma = double.Parse(Console.ReadLine());


                if (soma == 1) {
                    Console.WriteLine("Digite o primeiro numero");
                    soma = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero");
                    soma2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Resultado: " + (soma + soma2));

                }

                if (soma == 2)
                {
                    Console.WriteLine("Digite o primeiro numero");
                    soma = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero");
                    soma2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Resultado: " + (soma - soma2));

                }

                if (soma == 3)
                {
                    Console.WriteLine("Digite o primeiro numero");
                    soma = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero");
                    soma2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Resultado: " + (soma * soma2));

                }

                if (soma == 4)
                {
                    Console.WriteLine("Digite o primeiro numero");
                    soma = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero");
                    soma2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Resultado: " + (soma / soma2));

                }
                Console.ReadKey();

            }
        }
    }
}
