using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13CSharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco, aumento1, aumento2, aumento3;
            Console.WriteLine("Calcule o novo preço dos produtos \n Digite o preço do produto: ");
            preco = double.Parse(Console.ReadLine());
            var temp = "Barato";
            var temp2 = "Normal";
            var temp3 = "Caro";
            var temp4 = "Muito caro";

            if
                (preco <= 50) { Console.WriteLine("Novo preço: " + (preco + (preco * 0.05)) +  temp); }
            else if
                (preco > 50 && preco <= 100) { Console.WriteLine("Novo preço " + (preco + (preco * 0.10)) + temp2  ); }
            else if
                (preco > 100 && preco < 200) { Console.WriteLine("Novo preço " + (preco + (preco * 0.15)) + temp3); }
            else if
                (preco >= 200) { Console.WriteLine("Novo preço " + (preco + (preco * 0.15)) + temp4); }


            Console.ReadKey();
                
             










        }
    }
}
