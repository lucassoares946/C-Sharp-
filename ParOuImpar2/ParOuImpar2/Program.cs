using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Par ou Ímpar...");
            Console.WriteLine("Digite um nº inteiro positivo: ");
            x = int.Parse(Console.ReadLine());
            //x%2==0 significa que o resto da divisão de x por 2 é igual a 0
            //ou seja, x é PAR!!!
            if (x % 2 == 0)
            {
                Console.WriteLine(x + " é PAR!!!");
            }
            else
            { //x não é par ou que x%2 != 0 (o resto da divisão por 2 não é zero
                Console.WriteLine(x + " é ÍMPAR!!!");
            }
            Console.ReadKey();
        }
    }
}
