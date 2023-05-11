using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // estudante: ELVYNGTHON CAYRO LAMIN SAVIGNANO
            //2023mai02 - Lista de exercícios AULA 01
            
            /* Exercício 01 - Faça um programa que solicite ao usuário dois números inteiros e
            exiba a soma dos dois.*/
            Console.Write("ex1) Informe o primeiro número: ");
            int ex1A=int.Parse(Console.ReadLine());
            Console.Write("ex1) Informe o segundo número: ");
            int ex1B=int.Parse(Console.ReadLine());
            Console.WriteLine("ex1) SOMA: "+(ex1A+ex1B));
            // TÉRMINO DO EXERCÍCIO 01

            /* Exercício 02 - Escreva um programa que peça ao usuário um número e imprima o
            resultado da multiplicação desse número por 10 */
            Console.Write("ex2) Informe um número para decuplicar: ");
            int ex2A=int.Parse(Console.ReadLine());
            Console.WriteLine("ex2) 10 vezes o seu número: " + (ex2A * 10));
            // TÉRMINO DO EXERCÍCIO 02

            /* Exercício 03 - Faça um programa que peça ao usuário um número e calcule e exiba
            a raiz quadrada desse número */
            Console.Write("ex3) Informe um número para extrair a raiz: ");
            double ex3A=double.Parse(Console.ReadLine());
            Console.WriteLine("ex3) Raiz Quadrada: "+Math.Sqrt(ex3A));
            // TÉRMINO DO EXERCÍCIO 03

            /* Exercício 04 - Escreva um programa que solicite ao usuário o valor de três números
            inteiros diferentes e exiba o resultado da soma dos três números */
            Console.Write("ex4) Informe o primeiro número: ");
            int ex4A=int.Parse(Console.ReadLine());
            Console.Write("ex4) Informe o segundo número: ");
            int ex4B=int.Parse(Console.ReadLine());
            Console.Write("ex4) Informe o terceiro número: ");
            int ex4C=int.Parse(Console.ReadLine());
            Console.WriteLine("ex4) SOMA: "+(ex4A+ex4B+ex4C));
            // TÉRMINO DO EXERCÍCIO 04

            /* Exercício 05 - Faça um programa que solicite ao usuário um número real e imprima
            a metade desse número */
            Console.Write("ex5) Informe um número para dividir: ");
            double ex5A=double.Parse(Console.ReadLine());
            Console.WriteLine("ex5) A metade do seu número real: " + (ex5A / 2));
            // TÉRMINO DO EXERCÍCIO 05

            /* Exercício 06 - Escreva um programa que peça ao usuário dois números inteiros e
            exiba o resultado da divisão do primeiro número pelo segundo */
            Console.Write("ex6) Informe um número dividendo: ");
            int ex6A=int.Parse(Console.ReadLine());
            Console.Write("ex6) Informe um número divisor: ");
            int ex6B=int.Parse(Console.ReadLine());
            Console.WriteLine("ex6) Divisão de números inteiros: "+(ex6A / ex6B));
            // TÉRMINO DO EXERCÍCIO 06

            /* Exercício 07 - Faça um programa que solicite ao usuário um número e calcule e
            exiba o quadrado desse número */
            Console.Write("ex7) Informe um número de base: ");
            int ex7A=int.Parse(Console.ReadLine());
            Console.WriteLine("ex7) POTÊNCIA: "+(ex7A*ex7A));
            // TÉRMINO DO EXERCÍCIO 07

            /* Exercício 08 - Escreva um programa que peça ao usuário dois números reais e
            exiba o resultado da multiplicação dos dois. */
            Console.Write("ex8) Informe um número para multiplicar: ");
            double ex8A=double.Parse(Console.ReadLine());
            Console.Write("ex8) Informe outro número: ");
            double ex8B=double.Parse(Console.ReadLine());
            Console.WriteLine("ex8) PRODUTO: "+( ex8A*ex8B));
            // TÉRMINO DO EXERCÍCIO 08

            /* Exercício 09 - Faça um programa que solicite ao usuário um número inteiro e exiba
            o resultado da multiplicação desse número por 3. */
            Console.Write("ex9) Informe um número para triplicar: ");
            int ex9A=int.Parse(Console.ReadLine());
            Console.WriteLine("ex9) TRIPLO: " + (ex9A * 3));
            // TÉRMINO DO EXERCÍCIO 09

            /* Exercício 10 - Escreva um programa que peça ao usuário dois números
            inteiros e exiba o resultado da subtração do primeiro número pelo segundo. */
            Console.Write("ex10) Informe o número minuendo: ");
            int ex10A=int.Parse(Console.ReadLine());
            Console.Write("ex10) Informe o número subtraendo: ");
            int ex10B=int.Parse(Console.ReadLine());
            Console.WriteLine("ex10) DIFERENÇA: " + (ex10A - ex10B));
            // TÉRMINO DO EXERCÍCIO 10

            Console.ReadKey();
        }
    }
}
