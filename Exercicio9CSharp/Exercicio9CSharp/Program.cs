using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo, credito;
            Console.WriteLine("Credito especial \n Digite o seu saldo:");
            saldo = double.Parse(Console.ReadLine());
            if
            (saldo > 400) { Console.WriteLine("Seu saldo é " + saldo + "Seu crédito é " + saldo * 0.30); }
            else if
                (saldo < 400 && saldo > 300) { Console.WriteLine("Seu saldo é " + saldo + "Seu crédito é " + saldo * 0.25); }
            else if
                (saldo < 300 && saldo > 200) { Console.WriteLine("Seu saldo é " + saldo + "Seu crédito é " + saldo * 0.20); }
            else if
                (saldo <= 200) { Console.WriteLine("Seu saldo é " + saldo + "Seu crédito é " + saldo * 0.10); }
            Console.ReadKey();
        }
    }
}
