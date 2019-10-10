using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityDB.Model;
using EntityDB.Controller;

namespace ConsoleApp1
{
    class Program
    {
        static AlunoController aluno = new AlunoController();
        static void Main(string[] args)
        {
            StartApp();
        }

        public static void StartApp()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("MENU DO BANCO DE DADOS");
                Console.WriteLine("0- DIGITE PARA SAIR");
                Console.WriteLine("1- DIGITE PARA CADASTRAR");
                Console.WriteLine("2- DIGITE PARA LISTAR");
                Console.Write("OPÇÃO: ");
                switch (Console.ReadLine())
                {
                    case "0":
                        flag = false;
                        WaitUntil();
                        Console.Clear();
                        break;
                    case "1":
                        AddAluno();
                        WaitUntil();
                        Console.Clear();
                        break;
                    case "2":
                        ListAlunos();
                        WaitUntil();
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
        }

        public static void AddAluno()
        {
            Console.Write("Digite o nome do meliante: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a idade do meliante: ");
            int idade = int.Parse(Console.ReadLine());
            aluno.AddAlunos(
                new Aluno()
                {
                    Nome = nome,
                    Idade = idade
                });
        }
        public static void ListAlunos() => aluno.GetAlunos().ToList<Aluno>().ForEach(x => Console.WriteLine($"Id: {x.Id} Idade: {x.Idade} Nome: {x.Nome}"));
        public static void WaitUntil()
        {
            Console.WriteLine("--- PRESSIONE QUALQUER TECLA PARA CONTINUAR ---");
            Console.ReadKey();
        }
    }
}
