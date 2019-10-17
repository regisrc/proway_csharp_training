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
        static FloresController flor = new FloresController();

        static void Main(string[] args)
        {
            StartApp();
        }

        public static void StartApp()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("0 - PARA SAIR");
                Console.WriteLine("1 - PARA INSERIR");
                Console.WriteLine("2 - PARA RELATORIO");
                Console.Write("Sua opção: ");
            } while (ChoiceOption());
        }

        public static bool ChoiceOption()
        {
            switch (Console.ReadLine())
            {
                case "0":
                    return false;
                case "1":
                    AddFlor();
                    break;
                case "2":
                    ListaFlores();
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }

            return true;
        }

        private static void ListaFlores()
        {
            Console.Clear();
            var floresBuilder = "ID: {0,-3} FLOR: {1,-20} QUANTIDADE: {2,-4}";
            flor.GetFlores()
                .OrderByDescending(i => i.Quantidade)
                .ToList<Flores>()
                .ForEach(x => Console.WriteLine(string.Format(floresBuilder,x.Id,x.Nome,x.Quantidade)));
            Console.WriteLine($"QUANTIDADE TOTAL SOMADA: {flor.GetFlores().Sum(i => i.Quantidade).ToString()}");
            Console.WriteLine("PRESSIONE QUALQUER TECLA PARA VOLTAR");
            Console.ReadKey();
        }

        private static void AddFlor()
        {
            Console.Clear();
            Console.Write("Digite o nome da Flor: ");
            var nome = Console.ReadLine();
            Console.Write("Digite a quantidade de Flores: ");
            var qtd = Console.ReadLine();
            flor.AddFlores(new Flores()
            {
                Nome = nome,
                Quantidade = int.Parse(qtd)
            });
        }
    }
}
