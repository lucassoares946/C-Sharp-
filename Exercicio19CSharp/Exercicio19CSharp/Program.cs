using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio19CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, sexo, peso,dezoito;
            Console.WriteLine("Calcule se seu peso está ideal \nDigite Sua Altura");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite Seu Peso");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite:  \n1.Homem \n2.Mulher");
            sexo = double.Parse(Console.ReadLine());


            if
                (sexo == 1 && (peso / (altura * altura) ) < 18.5) { Console.WriteLine("Seu peso não está ideal "); }
            else if
                (sexo == 1 && (peso / (altura * altura) ) > 18.5 ) { Console.WriteLine("Seu peso está ideal "); }
            else if
                (sexo == 1 && (peso / (altura * altura) ) <= 25) { Console.WriteLine("Seu peso está ideal "); }


            else if
                (sexo == 2 && (peso / (altura * altura) ) < 18.5) { Console.WriteLine("Seu peso não está ideal "); }
            else if
                (sexo == 2 && (peso / (altura * altura) ) > 18.5) { Console.WriteLine("Seu peso está ideal "); }
            else if
                (sexo == 2 && (peso / (altura * altura) ) <= 25) { Console.WriteLine("Seu peso está ideal "); }
            Console.ReadKey();





        }
    }
}
