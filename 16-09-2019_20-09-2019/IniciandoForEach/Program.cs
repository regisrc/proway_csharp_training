using System;

namespace IniciandoForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o texto: ");
            var conteudoDoTexto = Console.ReadLine();

            foreach (var item in conteudoDoTexto)
                Console.WriteLine(item);
        }
    }
}
