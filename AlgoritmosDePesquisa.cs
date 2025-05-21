using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static implementacao_de_menu_interativo.MenuEstruturasDados;

namespace implementacao_de_menu_interativo
{
    internal class AlgoritmosDePesquisa
    {
        public static void SubMenuPesquisa()
        {
            int escolha;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Submenu de Algoritmos de Pesquisa:");
                Console.WriteLine("1. Busca Linear");
                Console.WriteLine("2. Busca Binária");
                Console.WriteLine("3. Voltar ao Menu Principal");
                Console.Write("Escolha uma opção (1-3): ");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        BuscaLinear();
                        break;
                    case 2:
                        BuscaBinaria();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        private static void BuscaLinear()
        {
            Console.Clear();
            Console.WriteLine("Escolha a estrutura de dados para pesquisa:");
            Console.WriteLine("1. Vetores");
            Console.WriteLine("2. Listas");
            Console.WriteLine("3. Pilhas");
            Console.WriteLine("4. Filas");
            Console.Write("Escolha uma opção (1-4): ");
            int escolha = int.Parse(Console.ReadLine());
            int valor = ObterValorDeBusca();

            switch (escolha)
            {
                case 1:
                    BuscaLinearEmVetor(valor);
                    break;
                case 2:
                    BuscaLinearEmLista(valor);
                    break;
                case 3:
                    BuscaLinearEmPilha(valor);
                    break;
                case 4:
                    BuscaLinearEmFila(valor);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        private static void BuscaBinaria()
        {
            Console.Clear();
            Console.WriteLine("Escolha a estrutura de dados para pesquisa:");
            Console.WriteLine("1. Vetores");
            Console.WriteLine("2. Listas");
            Console.WriteLine("3. Pilhas");
            Console.WriteLine("4. Filas");
            Console.Write("Escolha uma opção (1-4): ");
            int escolha = int.Parse(Console.ReadLine());
            int valor = ObterValorDeBusca();

            switch (escolha)
            {
                case 1:
                    BuscaBinariaEmVetor(valor);
                    break;
                case 2:
                    BuscaBinariaEmLista(valor);
                    break;
                case 3:
                    Console.WriteLine("Busca binária não é aplicável em pilhas.");
                    break;
                case 4:
                    Console.WriteLine("Busca binária não é aplicável em filas.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        private static int ObterValorDeBusca()
        {
            Console.Write("Digite o valor a ser buscado: ");
            return int.Parse(Console.ReadLine());
        }


        private static void BuscaLinearEmVetor(int valor)
        {
            bool encontrado = false;
            for (int i = 0; i < Vetores.vetor.Length; i++)
            {
                if (Vetores.vetor[i] == valor)
                {
                    Console.WriteLine($"Valor {valor} encontrado no índice {i} do vetor.");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"Valor {valor} não encontrado no vetor.");
            }
        }

       
        private static void BuscaLinearEmLista(int valor)
        {
            bool encontrado = false;
            for (int i = 0; i < Listas.lista.Count; i++)
            {
                if (Listas.lista[i] == valor)
                {
                    Console.WriteLine($"Valor {valor} encontrado no índice {i} da lista.");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"Valor {valor} não encontrado na lista.");
            }
        }

    
        private static void BuscaLinearEmPilha(int valor)
        {
            bool encontrado = false;
            foreach (var item in Pilha.pilha)
            {
                if (item == valor)
                {
                    Console.WriteLine($"Valor {valor} encontrado na pilha.");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"Valor {valor} não encontrado na pilha.");
            }
        }

      
        private static void BuscaLinearEmFila(int valor)
        {
            bool encontrado = false;
            foreach (var item in Fila.fila)
            {
                if (item == valor)
                {
                    Console.WriteLine($"Valor {valor} encontrado na fila.");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"Valor {valor} não encontrado na fila.");
            }
        }

       
        private static void BuscaBinariaEmVetor(int valor)
        {
            Array.Sort(Vetores.vetor);
            int inicio = 0;
            int fim = Vetores.vetor.Length - 1;
            bool encontrado = false;

            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2;
                if (Vetores.vetor[meio] == valor)
                {
                    Console.WriteLine($"Valor {valor} encontrado no índice {meio} do vetor.");
                    encontrado = true;
                    break;
                }
                else if (Vetores.vetor[meio] < valor)
                {
                    inicio = meio + 1;
                }
                else
                {
                    fim = meio - 1;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"Valor {valor} não encontrado no vetor.");
            }
        }

        
        private static void BuscaBinariaEmLista(int valor)
        {
            Listas.lista.Sort();
            int inicio = 0;
            int fim = Listas.lista.Count - 1;
            bool encontrado = false;

            while (inicio <= fim)
            {
                int meio = (inicio + fim) / 2;
                if (Listas.lista[meio] == valor)
                {
                    Console.WriteLine($"Valor {valor} encontrado no índice {meio} da lista.");
                    encontrado = true;
                    break;
                }
                else if (Listas.lista[meio] < valor)
                {
                    inicio = meio + 1;
                }
                else
                {
                    fim = meio - 1;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"Valor {valor} não encontrado na lista.");
            }
        }
    }
}
