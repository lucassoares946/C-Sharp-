using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio21CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco, origem;
            Console.WriteLine("De onde é seu produto? \nDigite o preço do produto: ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código de origem de 1 a 30");
            origem = double.Parse(Console.ReadLine());
            if
                (origem == 1) { Console.WriteLine("Seu Produto é do SUL e custa: " + origem ); }
            else if
                (origem == 2) { Console.WriteLine("Seu Produto é do NORTE e custa: " + origem); }
            else if
               (origem == 3) { Console.WriteLine("Seu Produto é do LESTE e custa: " + origem); }
            else if
               (origem == 4) { Console.WriteLine("Seu Produto é do OESTE e custa: " + origem); }
            else if
               (origem == 5) { Console.WriteLine("Seu Produto é do NORDESTE e custa: " + origem); }
            else if
               (origem == 6) { Console.WriteLine("Seu Produto é do NORDESTE e custa: " + origem); }
            else if
               (origem == 7) { Console.WriteLine("Seu Produto é do SUDESTE e custa: " + origem); }
            else if
               (origem == 8) { Console.WriteLine("Seu Produto é do SUDESTE e custa: " + origem); }
            else if
               (origem == 9) { Console.WriteLine("Seu Produto é do SUDESTE e custa: " + origem); }
            
            else if
              (origem > 21) { Console.WriteLine("Seu Produto é do NORDESTE e custa: " + origem); }
            else if
              (origem < 30) { Console.WriteLine("Seu Produto é do NORDESTE e custa: " + origem); }
            else if
               (origem > 10) { Console.WriteLine("Seu Produto é do CENTRO-OESTE e custa: " + origem); }
            else if
               (origem < 20) { Console.WriteLine("Seu Produto é do CENTRO-OESTE e custa: " + origem); }


            Console.ReadKey();

        }
    }
}
