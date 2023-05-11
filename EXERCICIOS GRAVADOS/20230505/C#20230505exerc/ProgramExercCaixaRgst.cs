using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ExercAula0505CaixaRgst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Caixa registradora com List<>
            1 - Crie um programa que simule uma caixa registradora. O programa deve receber um número desconhecido 
            de preços de produtos como entrada do usuário, usando o método Add() para adicionar cada valor à lista. 
            Quando o usuário digitar 0 como preço, o programa deve calcular o total da compra usando o 
            método Sum() da lista e exibi-lo na tela. Em seguida, o programa deve pedir ao usuário que informe 
            o valor em dinheiro que foi fornecido e calcular o troco usando o método Subtract() da classe Decimal. 
            Por fim, o programa deve limpar a lista e voltar ao ponto inicial. 
             */
            int op = 0;
            decimal p = 0, total=0, dinheiro=0, troco = 0;
            Console.WriteLine("Escolha alguma opção: (1) Fazer a compra | (2) Sair");

            List<decimal> compras = new List<decimal>();
            
            switch (op == 1)
            {
                case 1:
                    compras = new List<decimal>();
                    do
                    {
                        compras.Add(p);
                    } while (p!=0);
                    if (p == 0) 
                    {
                        total = compras.Sum();
                        Console.WriteLine("Total R$"+total); 
                    }
                    Console.WriteLine("Dinheiro (R$)");
                    dinheiro=Convert.ToDecimal(Console.ReadLine());

                    troco=Decimal.Subtract(total, dinheiro);
                    
                    Console.WriteLine("Troco R$" + troco);

                    compras.Clear();
                    compras.TrimExcess();
                    break;

                default: break;
            }

            Console.ReadKey();
        }
    }
}
