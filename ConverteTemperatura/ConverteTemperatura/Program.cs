using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverteTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            double milim, pol;
            Console.WriteLine("Quantidade de chuvas - conversão de polegadas a mm...");
            Console.WriteLine("Digite a quantidade de chuva, em polegadas: ");
            pol = double.Parse(Console.ReadLine());
            //polegadas = Convert.ToDouble(Console.ReadLine());
            //Processamento
            milim = 25.4 * pol;
            //Saída
            Console.WriteLine(pol + " pol. = " + milim + " mm. de chuva!");
            Console.ReadKey();
        }
    }
}
