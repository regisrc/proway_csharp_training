using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            String palavra = Console.ReadLine();
            Console.WriteLine($"{palavra.Replace("banana","laranja")}");
            Console.WriteLine("Aperte Qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
