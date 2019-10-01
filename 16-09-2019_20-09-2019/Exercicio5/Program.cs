using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            String palavra = Console.ReadLine();
            Console.WriteLine($"Primeiro caracter: '{palavra.Substring(0, 1)}'\n\rUltimo caracter: '{palavra.Substring(palavra.Length - 1)}'");
            Console.WriteLine("Aperte Qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
