using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0505
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> produtos = new List<decimal>();

            Console.WriteLine("PRODUTOS");
            
           

            
            foreach (decimal produto in produtos)
            {
                produtos.Add(produto);

                
            }

            decimal total = produtos.Sum();
            Console.WriteLine("Total a pagar: R$" + total);

            decimal dinheiro;
            decimal troco;

            Console.WriteLine("Informe o valor do dinheiro (R$)");
            dinheiro = Convert.ToDecimal(Console.ReadLine());

            troco = decimal.Subtract(dinheiro, total);
            Console.WriteLine("Troco R$" + troco);

            //List<decimal> produtos = new List<decimal>();

            // TÉRMINO DO EXERCICIO 1
            Console.ReadKey();
        }
    }
}
