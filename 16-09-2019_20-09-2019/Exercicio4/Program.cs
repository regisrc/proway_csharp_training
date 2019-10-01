using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra: ");
            Console.WriteLine("Quantidade de caracteres: " + Console.ReadLine().Length);
            Console.WriteLine("Aperte Qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
