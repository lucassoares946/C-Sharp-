using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio23Lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double preco, total_nota, desconto, preco_final;
            Console.WriteLine("Compra de produtos");
            Console.WriteLine("Digite o código do produto de 1 á 40");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de produtos comprados");
            quantidade = int.Parse(Console.ReadLine());
            if (codigo >= 1 && codigo <= 10) { preco = 10; }
            else if
                (codigo >= 11 && codigo <= 20) { preco = 15; }
            else if
                (codigo >= 21 && codigo <= 30) { preco = 20; }
            else
            { preco = 30; }
            total_nota = quantidade * preco;
            if(total_nota <= 250) { desconto = 0.05 * total_nota; }
            else if(total_nota < 500){ desconto = 0.10 * total_nota; }
            else { desconto = 0.15 * total_nota; }
            preco_final = total_nota - desconto;
            Console.WriteLine("Preco unitario R$ " + preco);
            Console.WriteLine("Preco Total R$ " + total_nota);
            Console.WriteLine("Desconto R$ " + desconto);
            Console.WriteLine("Desconto R$ " + preco_final);
            Console.ReadKey();



        }
    }
}
