using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade = 1, sexo, salario, cont = 0, maior = 0, menor = 0, contm = 0,idadec = 0,sexoc = 0,salariot = 0;
            while (idade >= 0) {
                Console.WriteLine("Digite sua idade");
                idade = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite 1.Masculino 2.Feminino");
                sexo = double.Parse(Console.ReadLine());
                Console.WriteLine("Digie seu´salário");
                salario = double.Parse(Console.ReadLine());
                cont++;
                salario += salariot;
                if(idade > maior)
                {
                    idade += maior;
                    
                }

                if (idade < menor)
                {
                    idade += menor;
                    idade += idadec;
                    if(sexo == 1)sexo += sexoc;
                    if (sexo == 2) sexo += 2;

                }

                if(salario <= 200 && sexo == 2)
                {
                    contm++;
                }

            }
            if (idade < 0)
            {
                Console.WriteLine("Média: " + salariot / cont);
                Console.WriteLine("Maior idade: " + maior + " Menor " + menor);
                Console.WriteLine("Mulheres que recebem até 200 " + contm);
                Console.WriteLine("Idade e sexo da pessoa que possue menor " + idadec + " Sexo 1 homem 2 mulher " + sexoc);
                Console.ReadKey();
            }
        }
    }
}
