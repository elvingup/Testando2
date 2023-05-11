using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0305
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            /*            Faça um Programa que peça dois números e 
             *            imprima o maior deles.
            */
            Console.WriteLine("Informe um número");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe outro número");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine(numero1 + " é maior do que " + numero2);
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine(numero2 + " é maior do que" + numero1);
            }
            else
            {
                Console.WriteLine("Os números são iguais");
            }

            /*  Faça um Programa que verifique se uma letra digitada é vogal 
             *  ou consoante.*/
            Console.WriteLine("Informe uma letra");
            string letra = Console.ReadLine();

            if (letra == "a" || letra == "b" || letra == "c" || letra == "d" || letra == "e")
            {
                Console.WriteLine("VOGAL");
            }
            else
            {
                Console.WriteLine("CONSOANTE");
            }

            // vogal ou consoante
            Console.WriteLine("Informe uma letra");
            char letraa = char.Parse(Console.ReadLine());

            if ("aeiouAEIOU".IndexOf(letraa) >= 0)
            {
                Console.WriteLine("VOGAL");
            }
            else
            {
                Console.WriteLine("CONSOANTE");
            }

            /* duas notas do aluno e tres comparações */
            Console.WriteLine("Informe uma nota");
            double nota1=double.Parse(Console.ReadLine());
            Console.WriteLine("Informe outra nota");
            double nota2=double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                Console.WriteLine("APROVADO");
            }else if (media < 7)
            {
                Console.WriteLine("reprovado");
            }
            else media == 10
                    {
                Console.WriteLine("Aprovado com Distinção");
            }

            //numero maior
            Console.WriteLine("numero 1");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("numero 2");
            int n2



            Console.ReadKey();
        }
    }
}
