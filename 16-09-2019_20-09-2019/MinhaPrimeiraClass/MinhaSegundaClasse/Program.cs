using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaSegundaClasse.Model;

namespace MinhaSegundaClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            var cestaFruta = new List<Frutas>
            {
                new Frutas()
                {
                    Nome = "Maçã",
                    Quantidade = 15
                },
                new Frutas()
                {
                    Nome = "Romã",
                    Quantidade = 65
                }
            };

            cestaFruta.ForEach(i => Console.WriteLine($"{i.Nome} {i.Quantidade}"));
            Console.ReadKey();
        }
    }
}
