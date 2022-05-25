using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio17CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;
            Console.WriteLine("Digite a senha para acessar");
            senha = int.Parse(Console.ReadLine());
            if
                (senha == 4531) { Console.WriteLine("Acesso Permitido !"); }
            else if
                (senha != 4531) { Console.WriteLine("Acesso Negado ! "); }
            Console.ReadKey();


        }
    }
}
