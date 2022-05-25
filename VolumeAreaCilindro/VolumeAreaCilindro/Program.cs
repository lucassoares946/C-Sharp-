using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeAreaCilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entradas 
            double raio, altura, area, volume;
            Console.WriteLine("Area e volume de um cilindro");
            Console.WriteLine("Digite o raio do cilindro em M");
            raio = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do cilindro");
            altura = double.Parse(Console.ReadLine());
            //Processamento
            area = 2 * Math.PI * raio * (altura + raio);
            volume = Math.PI * Math.Pow(raio, 2) * altura;
            //Saidas
            Console.WriteLine("A área do cilindro vale : " + Math.Round(area,2) + " m²");
            Console.WriteLine("O volume do cilindro vale : " + Math.Round(volume,2) + " m³");
            Console.ReadKey();
        }
        
    }
}
