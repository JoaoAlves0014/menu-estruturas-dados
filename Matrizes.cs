using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacao_de_menu_interativo
{
    internal class Matrizes
    {
        private static int[,] matriz;

        public static void SubMenuMatrizes()
        {
            int escolha;
            Console.Write("Digite o número de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine());
            matriz = new int[linhas, colunas];

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Submenu de Matrizes:");
                Console.WriteLine("1. Inserir elemento");
                Console.WriteLine("2. Exibir matriz");
                Console.WriteLine("3. Consultar elemento");
                Console.WriteLine("4. Voltar ao Menu Principal");
                Console.Write("Escolha uma opção (1-4): ");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        InserirElemento();
                        break;
                    case 2:
                        ExibirMatriz();
                        break;
                    case 3:
                        ConsultarElemento();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        private static void InserirElemento()
        {
            Console.Write("Digite o índice da linha (0 até {0}): ", matriz.GetLength(0) - 1);
            int linha = int.Parse(Console.ReadLine());
            Console.Write("Digite o índice da coluna (0 até {0}): ", matriz.GetLength(1) - 1);
            int coluna = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor a ser inserido: ");
            int valor = int.Parse(Console.ReadLine());

            if (linha >= 0 && linha < matriz.GetLength(0) && coluna >= 0 && coluna < matriz.GetLength(1))
            {
                matriz[linha, coluna] = valor;
                Console.WriteLine("Elemento inserido com sucesso.");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
        }

        private static void ExibirMatriz()
        {
            Console.WriteLine("Matriz:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private static void ConsultarElemento()
        {
            Console.Write("Digite o índice da linha: ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write("Digite o índice da coluna: ");
            int coluna = int.Parse(Console.ReadLine());

            if (linha >= 0 && linha < matriz.GetLength(0) && coluna >= 0 && coluna < matriz.GetLength(1))
            {
                Console.WriteLine($"Elemento na posição ({linha}, {coluna}): {matriz[linha, coluna]}");
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
        }
    }
}

