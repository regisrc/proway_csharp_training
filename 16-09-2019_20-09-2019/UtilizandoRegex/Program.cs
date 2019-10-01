using System;
using System.Text.RegularExpressions;

namespace UtilizandoRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            WithRegex();
        }

        private static void WithRegex()
        {
            var pattern = "[;']";
            var palavras = Regex.Split(getText(), pattern);
            foreach (var palavra in palavras) Console.WriteLine(palavra);
        }

        private static String getText() => @"Aqui; temos; um; texto; que; iremos; mudar; para; uma; coleção; e; vamos; colocar; isto; {seunome}; para; depois; usar; com; o; replace";

    }

}
