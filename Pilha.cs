using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacao_de_menu_interativo
{
    internal class Pilha
    {
        private static Stack<int> pilha = new Stack<int>();

        public static void SubMenuPilha()
        {
            int escolha;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Submenu de Pilha:");
                Console.WriteLine("1. Inserir elemento");
                Console.WriteLine("2. Remover elemento");
                Console.WriteLine("3. Exibir todos os elementos");
                Console.WriteLine("4. Consultar/Buscar elemento");
                Console.WriteLine("5. Voltar ao Menu Principal");
                Console.Write("Escolha uma opção (1-5): ");
                
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        InserirElemento();
                        break;
                    case 2:
                        RemoverElemento();
                        break;
                    case 3:
                        ExibirElementos();
                        break;
                    case 4:
                        ConsultarElemento();
                        break;
                    case 5:
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
            Console.Write("Digite o elemento a ser inserido: ");
            int elemento = int.Parse(Console.ReadLine());
            pilha.Push(elemento);
            Console.WriteLine($"Elemento {elemento} inserido na pilha.");
        }

        private static void RemoverElemento()
        {
            if (pilha.Count > 0)
            {
                int elemento = pilha.Pop();
                Console.WriteLine($"Elemento {elemento} removido da pilha.");
            }
            else
            {
                Console.WriteLine("Pilha vazia.");
            }
        }

        private static void ExibirElementos()
        {
            Console.WriteLine("Elementos da pilha:");
            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }
        }

        private static void ConsultarElemento()
        {
            Console.Write("Digite o elemento a ser consultado: ");
            int elemento = int.Parse(Console.ReadLine());

            if (pilha.Contains(elemento))
                Console.WriteLine($"Elemento {elemento} encontrado na pilha.");
            else
                Console.WriteLine("Elemento não encontrado.");
        }
    }
}
