using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ExercFinalListsLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] gabarito = { 'A', 'B', 'C', 'D', 'E', 'E', 'D', 'C', 'B', 'A' };
            char[] respostas = new char[10];

            int[] notas = new int[10];
            int[] qtdProvas = new int[10];

            int op = 0;
            int nota = 0;
            int seqProva = 0;


            do
            {
                Console.WriteLine("Escolha uma opção: (1) Fazer a prova | (2) Sair");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op == 1)
                {
                    case 1:
                        seqProva++;
                        qtdProvas = new int[] { seqProva };
                        foreach (char resposta in respostas)
                        {
                            Console.WriteLine("Questão " + resposta + " Responda");
                            respostas[resposta] = Convert.ToChar(Console.ReadLine());

                            if (respostas[resposta] >= 'A' && respostas[resposta] <= 'E')
                            {
                                Console.WriteLine(respostas[resposta]);
                            }
                            else
                            {
                                Console.WriteLine("Informe uma resposta válida");
                            }

                            if (respostas[resposta] == gabarito[resposta])
                            {
                                nota++;
                                notas = new int[] { nota };
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Informe uma opção válida.");
                        break;
                }

            } while (op == 1);
            Console.WriteLine("\n");
            Console.WriteLine("Nota maior: " + notas.Max(x => x.ToString()));
            Console.WriteLine("Nota menor: " + notas.Min(x => x.ToString()));
            Console.WriteLine("Total de Alunos: " + qtdProvas.Length);
            double mediaNotas = Convert.ToDouble(notas.Average());
            Console.WriteLine("Média das notas: " + mediaNotas.ToString());



            Console.WriteLine("\nCrie um gabarito novo");
            char[] gabarito = new char[10];

            foreach (char c in gabarito)
            {

                gabarito[c] = Convert.ToChar(Console.ReadLine());

                if (gabarito[c] >= 'A' && gabarito[c] <= 'E')
                {
                    gabarito = new char[] { c };
                }
            }


            Console.WriteLine("\nGabarito novo");

            foreach (char resposta in gabarito)
            {
                Console.WriteLine(gabarito[resposta]);
            }
        }


    }
}
}
