using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Controller;
using CatalogoCelulares.Model;

namespace CellDu
{
    class Program
    {
        public static CelularesController celulares = new CelularesController();
        static void Main(string[] args) => StartApp();

        public static void StartApp()
        {
            do
            {
                Console.WriteLine("0 - para sair");
                Console.WriteLine("1 - para inserir");
                Console.WriteLine("2 - para atualizar");
                Console.WriteLine("3 - para deletar");
                Console.WriteLine("4 - para listar");
                Console.Write("Sua opção: ");
            } while (ChoiseOption());
        }

        public static void MensagemSair()
        {
            Console.WriteLine("--- PRESSIONE QUALQUER TECLA PARA SAIR ---");
            Console.ReadKey();
            Console.Clear();
        }

        public static bool ChoiseOption()
        {
            switch (Console.ReadLine())
            {
                case "0":
                    MensagemSair();
                    return false;
                case "1":
                    Console.Clear();
                    InserirCelular();
                    MensagemSair();
                    break;
                case "2":
                    Console.Clear();
                    AtualizarCelular();
                    MensagemSair();
                    break;
                case "3":
                    Console.Clear();
                    DeletarCelular();
                    MensagemSair();
                    break;
                case "4":
                    Console.Clear();
                    ListarCelulares();
                    MensagemSair();
                    break;
            }
            return true;
        }

        public static void ListarCelulares()
        {
            Console.WriteLine(" LISTA CELULAR ");
            string pattern = "ID:{0,-3}  MARCA:{1,-20} MODELO:{2,-20} PREÇO:{3,-6}";
            celulares
                .GetCelulares()
                .ToList<Celular>()
                .ForEach(i => Console.WriteLine(string.Format(pattern, i.Id, i.Marca, i.Modelo, i.Preco.ToString("C3"))));
        }
        public static void DeletarCelular()
        {
            Console.WriteLine(" DELETAR CELULAR ");
            Console.Write("Informe o ID do celular: ");
            var id = int.Parse(Console.ReadLine());

            celulares.DeletarCelular(id);
        }
        public static void AtualizarCelular()
        {
            ListarCelulares();
            Console.WriteLine(" ATUALIZAR CELULAR ");
            Console.Write("Informe o ID do celular: ");
            var id = int.Parse(Console.ReadLine());
            var celular = celulares.GetCelulares().SingleOrDefault(i => i.Id == id);
            if (celular == null)
            {
                Console.WriteLine("Não foi achado o ID digitado!");
                return;
            }
            Console.Write("Informe a Marca do celular: ");
            var marca = Console.ReadLine();
            Console.Write("Informe o Modelo do celular: ");
            var modelo = Console.ReadLine();
            Console.Write("Informe o Preço do celular: ");
            var preco = double.Parse(Console.ReadLine());
            celular.Id = id;
            celular.Marca = marca;
            celular.Modelo = modelo;
            celular.Preco = preco;
            celulares.AtualizarCelular(celular);

        }

        public static void InserirCelular()
        {
            Console.WriteLine(" INSERIR CELULAR ");
            Console.Write("Informe a Marca do celular: ");
            var marca = Console.ReadLine();
            Console.Write("Informe o Modelo do celular: ");
            var modelo = Console.ReadLine();
            Console.Write("Informe o Preço do celular: ");
            var preco = double.Parse(Console.ReadLine());

            celulares.InsertCelular(new Celular()
            {
                Marca = marca,
                Modelo = modelo,
                Preco = preco
            });
        }
    }
}
