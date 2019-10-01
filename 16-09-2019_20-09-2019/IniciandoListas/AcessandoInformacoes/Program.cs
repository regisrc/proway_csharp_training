using System;
using MinhaBiblioteca;

namespace AcessandoInformacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSistema();
        }

        private static void MenuSistema()
        {
            Console.WriteLine("Escolha uma das opções do menu: ");
            Console.WriteLine("1 - Calculo de área");
            Console.WriteLine("2 - Mostrar Animação");
            Console.WriteLine("3 - Listar marcas de carro");
            Console.WriteLine("4 - Listar marcas de cerveja");
            Console.WriteLine("5 - Sair do sistema");

            var menuEscolhido = Console.ReadKey().KeyChar.ToString();

            switch (menuEscolhido)
            {
                case "1":
                    Console.Clear();
                    CalculaArea();
                    Console.Clear();
                    MenuSistema();
                    break;
                case "2":
                    Console.Clear();
                    PrintTree();
                    Console.Clear();
                    MenuSistema();
                    break;
                case "3":
                    Console.Clear();
                    ListaCarros();
                    Console.Clear();
                    MenuSistema();
                    break;
                case "4":
                    Console.Clear();
                    ListaCerveja();
                    Console.Clear();
                    MenuSistema();
                    break;
                default:
                    break;
            }

            Console.Clear();
        }

        public static void CalculaArea()
        {
            Console.Write("Infome o lado do quadrado: ");
            var lado = Int32.Parse(Console.ReadLine());

            var bibliotecaCalculos = new CalculoDeArea();

            Console.WriteLine($"Minha área é {bibliotecaCalculos.CalculaArea(lado)}");
            Console.WriteLine("-- Pressione uma tecla para continuar --");
            Console.ReadKey();
        }

        public static void ListaCarros()
        {
            var bibliotecaCalculos = new ListaCarros();
            bibliotecaCalculos.ListarMarcas();
            Console.WriteLine("-- Pressione uma tecla para continuar --");
            Console.ReadKey();
        }

        public static void ListaCerveja()
        {
            var bibliotecaCalculos = new ListarCerva();
            bibliotecaCalculos.ListarCerveja();
            Console.WriteLine("-- Pressione uma tecla para continuar --");
            Console.ReadKey();
        }

        public static void PrintTree()
        {
            var tree = new AnimacoesEmFrames();
            tree.PrintTree();
        }
    }
}
