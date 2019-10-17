using ClassLibrary.Controller;
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static BicicletaController bicicleta = new BicicletaController();
        static void Main(string[] args) => StartApp();

        public static void StartApp()
        {
            do
            {
                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Listar");
                Console.WriteLine("2 - Inserir");
                Console.WriteLine("3 - Atualizar");
                Console.WriteLine("4 - Remover");
                Console.Write("Sua opção: ");
            } while (ChoiceOption());
        }

        public static bool ChoiceOption()
        {
            switch (Console.ReadKey().KeyChar.ToString())
            {
                case "0":
                    return false;
                case "1":
                    Console.Clear();
                    bicicleta.ListBicicleta();
                    AskGerarJSON();
                    Console.WriteLine("PRESSIONE ALGUMA TECLA PARA SAIR");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    AddBicicleta();
                    Console.Clear();
                    break;
                case "3":
                    Console.Clear();
                    UpdateBike();
                    Console.Clear();
                    break;
                case "4":
                    Console.Clear();
                    RemoveBike();
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
            return true;
        }

        public static void AskGerarJSON()
        {
            Console.Write("Deseja gerar um relatório? (sim) ");
            if (Console.ReadLine().ToLower().Equals("sim"))
            {
                bicicleta.GerarJSON();
            }
        }

        public static string AskModelo()
        {
            var modelo = "";
            do
            {
                Console.Write("Digite o modelo da bike: ");
                modelo = Console.ReadLine();

            } while (string.IsNullOrEmpty(modelo));
            return modelo;
        }

        public static string AskMarca()
        {
            var marca = "";
            do
            {
                Console.Write("Digite a marca da bike: ");
                marca = Console.ReadLine();

            } while (string.IsNullOrEmpty(marca));
            return marca;
        }

        public static double AskValor()
        {
            var valor = 0.00;
            do
            {
                Console.Write("Digite o valor da bike: ");
                valor = double.Parse(Console.ReadLine());

            } while (valor < 0);
            return valor;
        }

        public static int AskID()
        {
            var valor = 0;
            do
            {
                Console.Write("Digite o ID: ");
                valor = int.Parse(Console.ReadLine());

            } while (valor < 0);
            return valor;
        }

        public static void AddBicicleta()
        {
            bicicleta.AddBicicleta(new Bicicletas()
            {
                Modelo = AskModelo(),
                Marca = AskMarca(),
                Valor = AskValor()
            });
        }

        public static void UpdateBike()
        {
            var Id = AskID();
            var bikeEscolhida = bicicleta.GetBicicletas().FirstOrDefault(i => i.Id == Id && i.Ativo);
            if (bikeEscolhida != null)
            {
                bikeEscolhida.Id = Id;
                bikeEscolhida.Modelo = AskModelo();
                bikeEscolhida.Marca = AskMarca();
                bikeEscolhida.Valor = AskValor();
                bicicleta.UpdateBicicleta(bikeEscolhida);
            }
        }

        public static void RemoveBike()
        {
            bicicleta.DeleteBicicleta(AskID());
        }

    }
}
