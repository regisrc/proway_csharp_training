using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome : ");
            String nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            int idade = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(generateMessage(idade, nome));
            Console.WriteLine("Aperte Qualquer tecla para continuar");
            Console.ReadKey();
        }

        private static bool VerifyAge(int idade) => idade >= 18;

        private static String generateMessage(int idade, String nome) => VerifyAge(idade) ? $"Parabéns {nome} você já esta na fase adulta." : $"Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade.";
    }
}
