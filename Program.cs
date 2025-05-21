using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static implementacao_de_menu_interativo.MenuEstruturasDados;

namespace implementacao_de_menu_interativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu Principal:");
                Console.WriteLine("1. Vetores");
                Console.WriteLine("2. Matrizes");
                Console.WriteLine("3. Trabalhar com Lista");
                Console.WriteLine("4. Trabalhar com Fila");
                Console.WriteLine("5. Trabalhar com Pilha");
                Console.WriteLine("6. Algoritmos de Pesquisa");
                Console.WriteLine("7. Encerrar");
                Console.Write("Escolha uma opção (1-7): ");

                escolha = int.Parse(Console.ReadLine());


                switch (escolha)
                {
                    case 1:
                        Vetores.SubMenuVetores();
                        break;
                    case 2:
                       Matrizes.SubMenuMatrizes();
                       break;
                    case 3:
                       Listas.SubMenuLista();
                       break;
                    case 4:
                        Fila.SubMenuFila();
                        break;
                    case 5:
                       Pilha.SubMenuPilha();
                        break;
                    case 6:
                        AlgoritmosDePesquisa.SubMenuPesquisa();
                        break;
                    case 7:
                        Console.WriteLine("Você escolheu Encerrar.");
                        return; 
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }
        }
    }
}
