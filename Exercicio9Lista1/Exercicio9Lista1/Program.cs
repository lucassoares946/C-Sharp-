using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9Lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, cem, cinquenta, dez, cinco, um;
            Console.WriteLine("Digite o valor que deseja sacar abaixo: ");
            valor = int.Parse(Console.ReadLine());
            cem = valor / 100;
            cinquenta = (valor % 100 )/ 50;
            dez = ((valor % 100) % 50) / 10;
            cinco = (((valor % 100) % 50) % 10) / 5;
            um = ((((valor % 100) % 50) % 10)% 5) / 1;
            Console.WriteLine("O valor digitado foi " + valor);
            Console.WriteLine("Você vai receber " + cem + " Notas de cem");
            Console.WriteLine("O valor digitado foi " + cinquenta + " Notas de cinquenta");
            Console.WriteLine("O valor digitado foi " + dez + " Notas de dez");
            Console.WriteLine("O valor digitado foi " + cinco + " Notas de cinco");
            Console.WriteLine("O valor digitado foi " + um + " Notas de um");
            Console.ReadKey();
        }
    }
}
