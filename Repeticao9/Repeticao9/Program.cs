using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeticao9
{
    class Program
    {
        static void Main(string[] args)
        {
            double ti, tf, F, aux;
            Console.WriteLine("Tabela de conversão, crescente de temperaturas...");
            Console.WriteLine("Digite a temperatura inicial, em ºF: ");
            ti = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a temperatura final, em ºF: ");
            tf = double.Parse(Console.ReadLine());
            //Troca de variáveis entre ti e tf
            if (ti > tf) { aux = ti; ti = tf; tf = aux; }
            Console.Clear();//Limpa a tela
            Console.WriteLine("Conversão de Farenheit a Celsius: ");
            for (F = ti; F <= tf; F++)
            {
                Console.WriteLine(F + "ºF = " + Math.Round(5 * (F - 32) / 9, 1) + " ºC");
            }
            Console.ReadKey();
        }

        }
    }

