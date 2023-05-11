using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0805
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* List<string> produtos = new List<string>();

             //Console.WriteLine();

             bool flag = true; // dar sinal de acesso; 

             while (flag) // flag=false é flag de saída
             {
                 Console.WriteLine("1-adicionar produto");
                 Console.WriteLine("2- remover produto");
                 Console.WriteLine("3- ver produtos cadastrados");
                 Console.WriteLine("0 - sair");

                 int op = int.Parse(Console.ReadLine());

                 switch (op) // 
                 {
                     case 1:
                         Console.WriteLine("adicionar produto");
                         Console.WriteLine("digite produto");
                         string produto = Console.ReadLine();
                         produtos.Add(produto);
                         break;

                     case 2:
                         Console.WriteLine("remover produto");
                         Console.WriteLine("digite produto");

                         Console.WriteLine(produtos.Remove(Console.ReadLine()) ?
                             "produto removido" :
                             "produto não encontrado");

                         if (produtos.Remove(Console.ReadLine()))
                         {
                             Console.WriteLine("produto removido");
                         }

                         break;

                     case 3:
                         Console.WriteLine("produto cadastrados");

                         for (int i = 0; i < produtos.Count; i++)
                         {
                             Console.WriteLine($"{(i + 1)} - {produtos[i]}");
                         }

                         break;

                     case 0:
                         Console.WriteLine("saindo...");
                         flag = false;
                         break;

                     default:
                         Console.WriteLine("valor invalido");
                         break;
                 }

                 // funciona com do{infotal}while(flag) também


                 string[] produtos2 = { "A", "b" }




                 Console.ReadKey();
                 Console.Clear();
             }

             // FASE 01


             string[] moedas = { "R$", "£", "US$" };

             const double VALOR_PAO = 0.18;

             for (int i = 1; i <= 50; i++)
             {
                 Console.WriteLine($"{i} - {moedas[0]}{i * VALOR_PAO}");
             }

             double[] valoresPao = new double[50];

             for (int i = 0; i < valoresPao.Length; i++)
             {
                 valoresPao[i] = (i + 1) * 0.18;
                 Console.WriteLine(valoresPao[i]);
             }
             Console.WriteLine("quantos paes");
             int qtd = int.Parse(Console.ReadLine());
             Console.WriteLine("valor final " + valoresPao[qtd]);

             List<Double> list = new List<Double>();
             Console.WriteLine("valor do pao");
             double valor = double.Parse(Console.ReadLine());
             for (int i = 0; i, list.Count; int++){
                 list.Add(i + 1) * valor;
             }

             foreach (double i in list)
             {
                 Console.WriteLine(i);
             }

             // lista não usa length - usa .Count()
             // lista metodo .Find()
             // FASE 01*/

            int pri = 0;
            int seg = 1;
            int prox;

            //int[] seq= new int[20];

            /*for(int i=0; i<20; i++)
            {
                
               prox=pri+seg;
                Console.WriteLine(prox);
                pri = seg;
                seg = prox;
            }*/

            /*Console.WriteLine("Digite o quantidade de elementos da série");
            int serie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Série " + serie + " numeros");

            Console.WriteLine("\nDigite o primeiro numero");
            int primeiro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t1º  nº " + primeiro);

            Console.WriteLine("\nDigite o segundo numero");
            int segundo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t2º  nº " + segundo);
            Console.WriteLine("\n");
            int proximo;

            for (int i = 0; i < serie; i++)
            {
                proximo = primeiro + segundo;
                Console.WriteLine(i + 1 + "º nº: " + proximo);
                primeiro = segundo;
                segundo = proximo;
            }*/

            Console.ReadKey();
        }
    }
}
