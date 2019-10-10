using ClassLibrary.Controller;
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static NomesController nomes = new NomesController();
        static void Main(string[] args)
        {
            StartApp();
        }

        public static void StartApp()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("LISTAGEM E ADD DE NOMES!");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Listar");
                Console.WriteLine("2 - Adicionar");
                Console.Write("Sua opção:  ");
            } while (OptionFromUser());
        }

        public static bool OptionFromUser()
        {
            switch (Console.ReadLine())
            {
                case "0":
                    return false;
                case "1":
                    Console.Clear();
                    ListaNomes();
                    break;
                case "2":
                    Console.Clear();
                    AddNome();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
            return true;
        }

        public static void AwaitForPress()
        {
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }

        public static void ListaNomes()
        {
            string stringFormat = "ID: {0, -3} NOME: {1,-50}";
            nomes.getNomes().ToList<Nomes>().ForEach(i => Console.WriteLine(string.Format(stringFormat, i.Id, i.Nome)));
            AwaitForPress();
        }

        public static void AddNome()
        {
            Console.Write("Digite um nome: ");
            nomes.AddNome(new Nomes()
            {
                Nome = Console.ReadLine()
            });
            AwaitForPress();
        }
    }
}
