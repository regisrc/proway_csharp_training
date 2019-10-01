using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo!");
            Console.Write("Digite seu nome completo: ");
            String nome = Console.ReadLine();
            Console.WriteLine($"Seja bem vindo, {nome}!");
            Console.WriteLine("Aperte Qualquer tecla para continuar");
            Console.ReadKey();
        }   
    }
}
