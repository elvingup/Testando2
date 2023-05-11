using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercListaCompras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2 - Lista de compras com List<>
            Crie um programa que permita ao usuário criar 
            uma lista de compras. O usuário pode adicionar 
            novos itens à lista usando o método Add(), 
            remover itens existentes usando o método Remove() 
            e exibir a lista completa usando o método foreach. 
            Quando o usuário tiver concluído sua lista, 
            ele deve sair do programa. */

            

            Console.WriteLine("Escolha alguma opção: (1) Adicionar itens || (2) Remover itens");
            int op=Convert.ToInt32(Console.ReadLine());

            List<string> compras = new List<string>();
            compras=new List<string>();

            switch(op)
            {
                case 1:
                    do
                    {
                        Console.WriteLine("Adicione algum item");

                        foreach (string item in compras)
                        {
                            compras.Add(item);

                            Console.WriteLine("Escolha alguma opção: (1) Adicionar item || (3) Concluir lista");
                            op = Convert.ToInt32(Console.ReadLine());
                            if (op == 3)
                            {
                                break;
                            }
                            else { op=1; }
                        }
                    } while (op == 1);
                    break;
                
                case 2:
                    do
                    {
                        Console.WriteLine("Informe o item para remover");
                        compras.Remove(Console.ReadLine());

                        Console.WriteLine("Quando concluir as remoções: escolha a opção (3) para informar a conclusão.");
                        op = Convert.ToInt32(Console.ReadLine());
                        if(op == 3)
                        {
                            break;
                        }
                        else { op=2; }

                    } while(op == 2);
                    break;
                
                default: break;
            }

            foreach (string item in compras)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Pressiona qualquer tecla para sair.");

            Console.ReadKey();
        }
    }
}
