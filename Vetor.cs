using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implementacao_de_menu_interativo
{
    internal class MenuEstruturasDados
    {
        public class Vetores
        {
            private static List<int> vetor = new List<int>();

            public static void SubMenuVetores()
            {
                int escolha;

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Submenu de Vetores:");
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

            public static void InserirElemento()
            {
                Console.Write("Digite o elemento a ser inserido: ");
                int elemento = int.Parse(Console.ReadLine());
                vetor.Add(elemento);
                Console.WriteLine($"Elemento {elemento} inserido com sucesso.");
            }

            public static void RemoverElemento()
            {
                Console.Write("Digite o elemento a ser removido: ");
                int elemento = int.Parse(Console.ReadLine());

                if (vetor.Remove(elemento))
                    Console.WriteLine($"Elemento {elemento} removido com sucesso.");
                else
                    Console.WriteLine("Elemento não encontrado.");
            }

            public static void ExibirElementos()
            {
                Console.WriteLine("Elementos do vetor:");
                foreach (var item in vetor)
                {
                    Console.WriteLine(item);
                }
            }

            public static void ConsultarElemento()
            {
                Console.Write("Digite o elemento a ser consultado: ");
                int elemento = int.Parse(Console.ReadLine());

                if (vetor.Contains(elemento))
                    Console.WriteLine($"Elemento {elemento} encontrado no vetor.");
                else
                    Console.WriteLine("Elemento não encontrado.");
            }
        }
    }
}
