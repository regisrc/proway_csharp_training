using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            String palavra = Console.ReadLine();
            Console.WriteLine($"'a': {GetCountPerLetter(palavra,"a")}\n'e': {GetCountPerLetter(palavra, "e")}\n'i': {GetCountPerLetter(palavra, "i")}\n'o': {GetCountPerLetter(palavra, "o")}\n'u': {GetCountPerLetter(palavra, "u")}\n");
            Console.WriteLine("Aperte Qualquer tecla para continuar");   
            Console.ReadKey();
        }

        private static int GetCountPerLetter(String palavra, String letra) => palavra.Split(letra).Length - 1;
    }
}
