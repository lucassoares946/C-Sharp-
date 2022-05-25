using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco, aumento1, aumento2, aumento3;
            Console.WriteLine("Calcule o novo preço dos produtos \n Digite o preço do produto: ");
            preco = double.Parse(Console.ReadLine());
            aumento1 = preco + (preco * 0.05);
            aumento2 = preco + (preco * 0.10);
            aumento3 = preco + (preco * 0.15);
            if
                (preco <= 50) { Console.WriteLine("O novo preço é:"); +(preco + (preco * 0.05); }
            else if
                (preco > 50 && preco <= 100) { Console.WriteLine("O novo preço é: "); + (preco + (preco * 0.10); }
            

           
            
            Console.ReadKey();

        }
    }
}
