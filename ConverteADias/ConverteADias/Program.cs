using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverteADias
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entradas
            int anos, meses, dias, tempo_em_dias;
            string nome;
            Console.WriteLine("Calculo da quantidade de dias vividos por uma pessoa");
            Console.WriteLine("Digite o nome da pessoa");
            nome = Console.ReadLine();
            Console.WriteLine("Digite quantos anos " + nome + " tem: ");
            anos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantos meses");
            meses = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantos dias");
            dias = int.Parse(Console.ReadLine());
            //Processamento
            tempo_em_dias = anos * 365 + 30 +  dias;
            //Saida
            Console.WriteLine("\n" + nome + "viveu já aproximadamente, " + tempo_em_dias + "dias");
            

            Console.ReadKey();

        }
    }
}
