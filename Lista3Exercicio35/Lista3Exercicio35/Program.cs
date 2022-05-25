using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercicio35
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 1, positivo = 0, negativo = 0;
            while (p < 0 || p > 0)
            {
                Console.WriteLine("Digite um numero negativo ou positivo");
                p = double.Parse(Console.ReadLine());
                if(p > 0)
                {
                    positivo += p;
                }

                if (p < 0)
                {
                    negativo += p;
                }

                Console.WriteLine("Soma dos numeros positivos com negativos:"+ (positivo + negativo))
                    ;

            }
            if (p == 0)
            {
                Console.WriteLine("Soma de positivos e negativos \nPositivos: "+ positivo + "\nNegativos: "+ negativo);
                Console.ReadKey();
            }
        }
    }
}
