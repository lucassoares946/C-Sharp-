using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisivelNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("Divisibilidade entre dois números: ");
            Console.WriteLine("Digite o 1º nº inteiro positivo: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º nº inteiro positivo: ");
            B = int.Parse(Console.ReadLine());
            if (B == 0) { Console.WriteLine("Não existe divisão por zero!"); }
            else
            { //(B é diferente de 0)
                if (A % B == 0) { Console.WriteLine(A + " é divisível por " + B); }
                // A % B = 0 => A é divisível por B
                //o else significa que A % B != 0 => A NÃO é divisível por B
                else { Console.WriteLine(A + " NÃO é divisível por " + B); }
            }
            Console.ReadKey();







        }
    }
}
