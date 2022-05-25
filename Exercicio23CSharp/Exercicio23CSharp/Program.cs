using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio23CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double cod, quanti, preco1, preco2, preco3, preco4;
            Console.WriteLine("Digite o codigo do produto comprado");
            cod = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de produtos");
            quanti = double.Parse(Console.ReadLine());
            preco1 = 10;
            preco2 = 15;
            preco3 = 20;
            preco4 = 30;
            

            if
                (cod > 1 && cod <= 10 && quanti * preco1 < 250) { Console.WriteLine("Preco unitario " + preco1 + " Preço total " + (quanti * preco1) + " Desconto " + (quanti * preco1 * 0.05) + " Preço final " + (quanti * preco1 - quanti * preco1 * 0.05)); }
            else if
                (cod > 11 && cod <= 20 && quanti * preco2 < 250) { Console.WriteLine("Preco unitario " + preco2 + " Preço total " + (quanti * preco2) + " Desconto " + (quanti * preco2 * 0.05) + " Preço final " + (quanti * preco2 - quanti * preco2 * 0.05)); }
            else if
                (cod > 21 && cod <= 30 && quanti * preco3 < 250) { Console.WriteLine("Preco unitario " + preco3 + " Preço total " + (quanti * preco3) + " Desconto " + (quanti * preco3 * 0.05) + " Preço final " + (quanti * preco3 - quanti * preco3 * 0.05)); }
            else if
                (cod > 31 && cod <= 40 && quanti * preco4 < 250) { Console.WriteLine("Preco unitario " + preco4 + " Preço total " + (quanti * preco4) + " Desconto " + (quanti * preco4 * 0.05) + " Preço final " + (quanti * preco4 - quanti * preco4 * 0.05)); }
            else if
                (cod > 1 && cod <= 10 && preco1 > 250 && quanti * preco1 < 500) { Console.WriteLine("Preco unitario " + preco1 + " Preço total " + (quanti * preco1) + " Desconto " + (quanti * preco1 * 0.10) + " Preço final " + (quanti * preco1 - quanti * preco1 * 0.10)); }
            else if
                (cod > 11 && cod <= 20 && preco2 > 250 && quanti * preco2 < 500) { Console.WriteLine("Preco unitario " + preco2 + " Preço total " + (quanti * preco2) + " Desconto " + (quanti * preco2 * 0.10) + " Preço final " + (quanti * preco2 - quanti * preco2 * 0.10)); }
            else if
                (cod > 21 && cod <= 30 && preco1 > 250 && quanti * preco3 < 500) { Console.WriteLine("Preco unitario " + preco3 + " Preço total " + (quanti * preco3) + " Desconto " + (quanti * preco3 * 0.10) + " Preço final " + (quanti * preco3 - quanti * preco3 * 0.10)); }
            else if
                (cod > 31 && cod <= 40 && preco1 > 250 && quanti * preco4 < 500) { Console.WriteLine("Preco unitario " + preco4 + " Preço total " + (quanti * preco4) + " Desconto " + (quanti * preco4 * 0.10) + " Preço final " + (quanti * preco4 - quanti * preco4 * 0.10)); }
            else if
                (cod > 1 && cod <= 10 && quanti * preco1 > 500) { Console.WriteLine("Preco unitario " + preco1 + " Preço total " + (quanti * preco1) +  "Desconto " + (quanti * preco1 * 0.15) + " Preço final " + (quanti * preco1 - quanti * preco1 * 0.15)); }
            else if
                (cod > 11 && cod <= 20 && quanti *  preco2 > 500) { Console.WriteLine("Preco unitario " + preco2 + " Preço total " + (quanti * preco2) + " Desconto " + (quanti * preco2 * 0.15) + " Preço final " + (quanti * preco2 - quanti * preco2 * 0.15)); }
            else if
                (cod > 21 && cod <= 30 && quanti * preco3 > 500 ) { Console.WriteLine("Preco unitario " + preco3 + " Preço total" + (quanti * preco3) + " Desconto " + (quanti * preco3 * 0.15) + " Preço final " + (quanti * preco3 - quanti * preco3 * 0.15)); }
            else if
                (cod > 31 && cod <= 40 && quanti * preco4 > 500 ) { Console.WriteLine("Preco unitario " + preco4 + " Preço total" + (quanti * preco4) + " Desconto " + (quanti * preco4 * 0.15) + " Preço final " + (quanti * preco3 - quanti * preco4 * 0.15)); }
            Console.ReadKey();

        }
    }
}
