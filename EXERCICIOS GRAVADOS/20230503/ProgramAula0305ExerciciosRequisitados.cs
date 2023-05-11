using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Aula0305
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // estudante: ELVYNGTHON CAYRO LAMIN SAVIGNANO
            // 2023mai03 Lista de Exercícios AULA 0305


            /*EXERCÍCIO 01 - Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja
            inválido e continue pedindo até que o usuário informe um valor válido*/
            Console.WriteLine("Informe uma nota");
            double nota = double.Parse(Console.ReadLine());
            while (!(nota >= 0 && nota <= 10))
            {
                Console.WriteLine("Informe uma nota de zero até dez.");
                nota = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("A nota é: " + nota);
            // TÉRMINO DO EXERCÍCIO 01

            /*EXERCÍCIO 02 - Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do
            usuário, mostrando uma mensagem de erro e voltando a pedir as informações*/
            Console.WriteLine("Informe o seu nome");
            string nome = Console.ReadLine();
            string senha = Console.ReadLine();
            while (senha == nome)
            {
                Console.WriteLine("A senha precisa ser diferente do nome. Informe uma senha válida");
                senha = Console.ReadLine();
            }
            Console.WriteLine("Senha válida informada");
            // TÉRMINO DO EXERCÍCIO 02

            /*EXERCÍCIO 04 - Supondo que a população de um país A seja da ordem de 80000 habitantes com uma taxa anual de
            crescimento de 3% e que a população de B seja 200000 habitantes com uma taxa de crescimento de
            1.5%. Faça um programa que calcule e escreva o número de anos necessários para que a população
            do país A ultrapasse ou iguale a população do país B, mantidas as taxas de crescimento*/
            int paisA = 80000;
            double taxA = 0.03;
            int paisB = 200000;
            double taxB = 0.015;
            int prazo = 0;
            while (paisA < paisB)
            {
                paisA = (int)(paisA + (paisA * taxA));
                paisB = (int)(paisB + (paisB * taxB));
                prazo++;
            }
            Console.WriteLine("A população do País A precisa de " + prazo + " anos para alcançar os números da população do Pais B");
            // TÉRMINO DO EXERCÍCIO 04

            /* EXERCÍCIO 10 - Faça um programa que receba dois números inteiros e gere os números inteiros 
             * que estão no intervalo compreendido por eles*/
            Console.WriteLine("Primeiro numero");
            int numero1=int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo numero");
            int numero2=int.Parse(Console.ReadLine());
            Console.WriteLine("SEQUENCIA");
            int numero;
            if ((numero1 != numero2) && (numero2-numero1)<55 && (numero1-numero2)<55)
            {
                if (numero1 > numero2)
                {
                    numero = numero2;
                    Console.WriteLine(numero);
                    while (numero < numero1 && numero >= numero2) {
                        numero = numero + 1;
                        Console.WriteLine(numero); 
                    }
                    
                }else if (numero1 < numero2)
                {
                    numero = numero1;
                    Console.WriteLine(numero);
                    while (numero>=numero1 && numero<numero2){ 
                        numero = numero+1;
                        Console.WriteLine(numero);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
