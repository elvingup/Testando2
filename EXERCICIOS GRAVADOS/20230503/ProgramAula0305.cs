using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Aula0305
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //numero maior
            Console.WriteLine("Informe um numero");
            int numero1=int.Parse(Console.ReadLine());
            Console.WriteLine("Informe outro numero");
            int numero2=int.Parse(Console.ReadLine());

            if (numero1 == numero2)
            {
                Console.WriteLine("NUMEROS IGUAIS");
            }
            else if (numero1>numero2) {
                Console.WriteLine(numero1+" é maior do que "+numero2);
            }
            else
            {
                Console.WriteLine(numero2+"é maior do que"+numero1);
            }

            // vogal ou consoante
            Console.WriteLine("Digite uma letra");
            char letra = char.ToLower(Convert.ToChar(Console.ReadLine()));

            if(letra=='a'||letra=='e'||letra=='i'|| letra == 'o' || letra == 'u')
            {
                Console.WriteLine("VOGAL");
            }else if (letra>='a' && letra <= 'z')
            {
                Console.WriteLine("CONSOANTE");
            }
            else
            {
                Console.WriteLine("Não é letra");
            }

            // media do estudante
            Console.WriteLine("Informe uma nota");
            double nota1=double.Parse(Console.ReadLine());
            Console.WriteLine("Informe outra nota");
            double nota2=double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            if (media == 10)
            {
                Console.WriteLine("Aprovado com Distinção");
            }else if (media >= 7)
            {
                Console.WriteLine("Aprovado");
            }else
            {
                Console.WriteLine("Reprovado");
            }

                     


            Console.ReadKey();
        }
    }
}
