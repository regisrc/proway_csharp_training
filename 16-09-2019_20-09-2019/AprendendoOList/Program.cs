using System;
using System.Collections.Generic;

namespace AprendendoOList
{
    class Program
    {

        static List<string> minhaListaPulgmatica = new List<string>()
        {
                "Filipe",
                "Irineu",
                "Serilop"
        };

        private static void AdicionarItensALista()
        {
            Console.Clear();
            Console.Write("Informe um nome: ");
            minhaListaPulgmatica.Add(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Nome: '{minhaListaPulgmatica[minhaListaPulgmatica.Count - 1]}' foi adicionado a lista!");

            Console.WriteLine("Deseja informa mais valores? sim(S) não(N) : ");

            if (Console.ReadKey().KeyChar.ToString().ToLower() == "s")
                AdicionarItensALista();
        }

        static void Main(string[] args)
        {

            AdicionarItensALista();

            ListaInformacoes();
        }

        private static void ListaInformacoes()
        {
            Console.Clear();
            Console.WriteLine("Nomes Adicionados a Lista: ");
            foreach (var item in minhaListaPulgmatica)
                Console.WriteLine($"Nome: {item} foi adicionado a lista!");
        }
    }
}
