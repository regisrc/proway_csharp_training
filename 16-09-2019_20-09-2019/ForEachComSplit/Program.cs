using System;

namespace ForEachComSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            ForEachComSplitEReplace();
        }

        private static void ForEachComSplit()
        {
            var conteudoDoText = @"Aqui; temos; um; texto; que; iremos; mudar; para; uma; coleção; e; vamos; colocar; isto; {seunome}; para; depois; usar; com; o; replace";

            Console.Write("Informe a palavra para realizar a busca: ");
            var palavra = Console.ReadLine();

            var counteudoTextoSplit = conteudoDoText.Split(palavra);
            foreach (var item in counteudoTextoSplit) Console.WriteLine(item);
        }

        private static void ForEachComSplitEReplace()
        {
            var conteudoDoText = @"Aqui; temos; um; texto; que; iremos; mudar; para; uma; coleção; e; vamos; colocar; isto; {seunome}; para; depois; usar; com; o; replace";

            Console.Write("Informe seu nome: ");
            var nome = Console.ReadLine();
            var palavra = "";
            var counteudoTextoSplit = conteudoDoText.Replace("{seunome}", nome).Split(';');
            foreach (var item in counteudoTextoSplit)
            {
                palavra += item;
                Console.WriteLine(item);
            }
            Console.WriteLine(palavra);
        }
    }
}
