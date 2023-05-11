using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Aula0805
{
    internal class Class1
    {
        public Class1() {
            /*
             1 - Desafio de Fibonacci: Escreva um programa que 
            imprima a sequência de Fibonacci até o décimo termo. 
            A sequência de Fibonacci é definida como:
            0, 1, 1, 2, 3, 5, 8, 13, 21, ...

             */

            Console.WriteLine("Digite o quantidade de elementos da série");
            int serie=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Série "+serie+" numeros");

            Console.WriteLine("\nDigite o primeiro numero");
            int primeiro=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t1º  nº "+primeiro);

            Console.WriteLine("\nDigite o segundo numero");
            int segundo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t2º  nº "+segundo);
            Console.WriteLine("\n");
            int proximo;

            for(int i = 0; i < serie; i++)
            {
                proximo = primeiro + segundo;
                Console.WriteLine(i+1 +"º nº: "+ proximo);
                primeiro = segundo;
                segundo = proximo;
            }

            // TÉRMINO DO EXERCÍCIO FIBONACCI

            /*
             2 - Desafio de soma de múltiplos:
            Escreva um programa que calcule a soma de todos os 
            números múltiplos de 3 ou 5 abaixo de 1000.

             */


            double[] multiplos = new double[] { };
            multiplos= new double[] { };
            double multi = 0;

            for (int i=0;i<100;i++) 
            {
                multi= multi + i;
                if(multi%3==0 || multi % 5 == 0)
                {
                    multiplos = new double[] { multi };
                }
            }

            double soma = multiplos.Sum();
            Console.WriteLine("SOMA DOS MULTIPLOS :"+soma);


            // TÉRMINO DO EXERCICIO DA SOMA DOS MULTIPLOS

            /*
             3 - Crie um sistema que identifique se um numero digitado 
            pelo usuário é primo.
             */

            Console.WriteLine("Digite algum numero inteiro");
            int numero=Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i < numero; i++)
            {
                if(numero % i==0)
                {
                    Console.WriteLine("Numero não é primo");
                    break;
                }
                else
                {
                    Console.WriteLine("Numero Primo");
                    break;
                }
            }
            
           
            // TÉRMINO DO EXERCÍCIO DOS NUMEROS PRIMOS
        }
    }
}
