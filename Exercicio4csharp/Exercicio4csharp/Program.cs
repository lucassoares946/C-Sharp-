using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, soma = 0, qtde = 0, maior, menor;
            int soma_pares = 0, conta_pares = 0, conta_impares = 0;
            double media_pares, media_total, porc_impares;
            Console.WriteLine("Vários Números - Completo");
            Console.WriteLine("Digite um nº inteiro positivo, ou 0 para terminar:");
            num = int.Parse(Console.ReadLine());
            maior = num; menor = num;
            while (num > 0)
            {
                if (num % 2 == 0) //num é PAR
                {
                    conta_pares++;
                    soma_pares += num;
                }
                else { conta_impares++; }
                qtde++;
                soma += num;
                Console.WriteLine("Digite um nº inteiro positivo, ou 0 para terminar:");
                num = int.Parse(Console.ReadLine());
                if (num > maior) { maior = num; }
                else if (num < menor && num > 0) { menor = num; }
            }
            Console.Clear();
            Console.WriteLine("Foram digitados " + qtde + " números");
            Console.WriteLine("A soma dos números digitados foi: " + soma);
            if (qtde > 0)
            {
                media_total = soma / qtde;
                Console.WriteLine("A média dos números digitados foi: " + Math.Round(media_total, 2));
                Console.WriteLine("Maior número digitado: " + maior);
                Console.WriteLine("Menor número digitado: " + menor);
            }
            else { Console.WriteLine("Não foram digitados números positivos"); }
            Console.ReadKey();
            if (conta_pares > 0)
            {
                media_pares = soma_pares / qtde;
                Console.WriteLine("Média dos pares digitados = " + Math.Round(media_pares, 2));
            }
            else { Console.WriteLine("Não foram digitados pares!!!!"); }
            porc_impares = 100 * conta_impares / qtde;
            Console.WriteLine("Porcentagem de ímpares: " + porc_impares + "%");
        }
    }
}
