using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;
using EntityClass.Controller;

namespace ConsoleApp1
{
    class Program
    {
        static PessoaController pessoa = new PessoaController();
        static void Main(string[] args)
        {
            pessoa.AddPessoa(
                new Pessoa()
                {
                    Nome = "Felipe"
                }
                );
            pessoa.GetPessoas().ToList<Pessoa>().ForEach(x => Console.WriteLine(x.Nome));
            Console.ReadKey();
        }
    }
}
