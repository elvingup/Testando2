using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0405
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AULA 4 de maio - EXERCÍCIOS 1 e 2 DA LISTA DE VETORES que foram solicitados durante a Aula
            
            /*Faça um programa que lê 10 números inteiros do teclado e armazene em um
           vetor. Ao final imprima o vetor armazenado nos dois sentidos*/

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine(" ");
            for (int i = 0; i < 11; i++)
            {
                Console.Write(i + " ");

            }

            // TÉRMINO DE EXERCÍCIO 01
/*
            Console.WriteLine("\n");
            *//*Ler um vetor de 10 elementos. Crie um segundo vetor, com todos os
           elementos na ordem inversa, ou seja, o último elemento passará a ser o
           primeiro, o penúltimo será o segundo e assim por diante. Imprima os dois
           vetores.*//*

            Console.WriteLine("\nSÉRIE ORIGINAL");
            int[] numeros = new int[10];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i;
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("\nSÉRIE REVERSA ABAIXO");
            int[] serieRev=new int[numeros.Length];
            for (int i = 0;i < serieRev.Length;i++) { 
                serieRev[i] = numeros[numeros.Length - 1 -i];
                Console.WriteLine(serieRev[i]);
            }

            // TERMINO EXERCICIO 02*/

            // exercicio 30 lista for while
            /* O Sr. Manoel Joaquim acaba de adquirir uma panificadora e pretende implantar a metodologia da
            tabelinha, que já é um sucesso na sua loja de 1,99.Você foi contratado para desenvolver o programa
            que monta a tabela de preços de pães, de 1 até 50 pães, a partir do preço do pão informado pelo
            usuário,*/
            double[] paes = new double[50];
            foreach (double preco in paes)
            {
                double preco = Convert.ToDouble(Console.ReadLine());
                paes[preco] = preco;
            }


            Console.ReadKey();


            Console.ReadKey();
        }
    }
}
