using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TesteTecnico.AmigosProximos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string opcao = ApresentarMenu();

                if (opcao == "1")
                {
                    AdicionarNovoAmigo();
                }
                else if (opcao == "2")
                {
                    ListarTodosAmigos();
                }
                else if (opcao == "3")
                {
                    AlterarAmigoViajando();
                }
                else if (opcao == "4")
                {
                    ListarAmigosProximo();
                }
                else if (opcao == "0")
                {
                    Environment.Exit(0);
                }

            } while (true);


        }

        private static string ApresentarMenu()
        {
            Console.WriteLine("========================================================================");
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("========================================================================");
            Console.WriteLine("1 - Adicionar novo amigo.");
            Console.WriteLine("2 - Listar todos os amigos.");
            Console.WriteLine("3 - Marcar amigo hospedando");
            Console.WriteLine("4 - Mostra os 3 amigos mais próximos");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("========================================================================");

            string opcao = Console.ReadLine();

            return opcao;
        }

        private static void ListarAmigosProximo()
        {
            Console.WriteLine("Listar amigos próximos");

        }

        private static void AdicionarNovoAmigo()
        {
            Console.WriteLine("------------------------------ Adicionar -------------------------------");
            Console.WriteLine("========================================================================");
            Console.WriteLine("Entre com o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Você esta hospedado nessa amigo: [S]im ou [N]ão ?");
            string viajando = Console.ReadLine();
            Console.WriteLine("Entre com a latitude: ");
            string latitude = Console.ReadLine();
            Console.WriteLine("Entre com a longitude: ");
            string longitude = Console.ReadLine();


        }

        private static void AlterarAmigoViajando()
        {
            Console.WriteLine("Alterar amigo viajando");
        }

        private static void ListarTodosAmigos()
        {
            Console.WriteLine("Listar todos os amigos.");
        }
    }
}
