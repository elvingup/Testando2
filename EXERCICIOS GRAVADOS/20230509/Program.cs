using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0905
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*FIBONACCI*/
            /*int n1 = 1, n2 = 0, prox = 0;

            for (int i = 0; i < 22; i++)
            {
                prox = n1 + n2;
                n2 = n1;
                n1=prox;
                Console.WriteLine(prox);
            }*/
            //TERMINO

            /*multiplos soma*/

            /*double soma = 0;
            for(int i = 0;i < 22; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) soma += i;
            }

                // OU

            List<double> list = new List<double>();
            for(int i = 0; i < 22; i++)
            {
                if(i % 3 == 0 || i %5== 0) list.Add(i);
            }
            Console.WriteLine(soma);
             */
            //TERMINO

            /* numeros primos */
            Console.WriteLine("digite");
            int numero=int.Parse(Console.ReadLine());
            int cont = 0;
            for(int i = numero; numero>0; i--)
            {
                if(numero%i==0) cont++;
            }
            
                // § 1
            if (cont == 2)
            {
                Console.WriteLine("PRIMO");
            }else { Console.WriteLine("não é primo"); }
            // § 2
            Console.WriteLine(cont == 2 ? "PRIMO" : "nao é primo");
            //TERMINO

            /* alternativa pra numeros primos
             * 
             * down cast para o menor numero possivel
             * BINARIZAÇÃO ou SERIALIZAÇÃO
             * simplifica a verificação
             * OOP sqrt
                          
             */

            //TERMINO


            Console.ReadKey();
        }
    }
}
