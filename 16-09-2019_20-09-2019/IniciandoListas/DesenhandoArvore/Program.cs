using System;
using System.Collections.Generic;
using System.Threading;

namespace DesenhandoArvore
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintTree();
        }

        public static void ListarMarcas()
        {
            var listaMarcas = new List<string>();
            listaMarcas.Add("Renault");
            listaMarcas.Add("Fiat");
            listaMarcas.Add("Citroen");
            listaMarcas.Add("Ferrari");
            listaMarcas.Add("BMW");
            listaMarcas.ForEach(i => Console.WriteLine(i));
        }

        public static void ListarCerveja()
        {
            var listaCerveja = new List<string>();
            listaCerveja.Add("Original");
            listaCerveja.Add("Skol");
            listaCerveja.Add("Budweiser");
            listaCerveja.Add("Brahma");
            listaCerveja.ForEach(i => Console.WriteLine(i));
        }

        public static void CalcularArea()
        {
            Console.Write("Digite a base do quadrado: ");
            var baseQuadr = Console.ReadLine();
            Console.Write("Digite a altura do quadrado: ");
            var alturaQuadr = Console.ReadLine();
            Console.WriteLine($"Área do quadrado: {Convert.ToInt32(baseQuadr) * Convert.ToInt32(alturaQuadr)}");
        }

        public static void PrintTree()
        {
            var caracter = "/";
            var caracterCresce = $"\\";
            var tamanhoLenght = 10;
            var tamanhoEspacos = 10;
            Random randNum = new Random();
            while (true)
            {
                for (int i = 0; i <= tamanhoLenght; i++)
                {
                    for (int b = 0; b < tamanhoEspacos; b++)
                    {
                        Console.Write(" ");
                    }
                    tamanhoEspacos--;
                    Console.Write(caracter);
                    for (int j = 0; j < i; j++)
                    {
                        if (randNum.Next(100) % 2 == 0)
                            Console.Write("0");
                        else
                            Console.Write("1");
                        if (randNum.Next(100) % 2 == 0)
                            Console.Write("1");
                        else
                            Console.Write("0");
                    }
                    Console.WriteLine($"{caracterCresce}");
                }
                for (int c = 0; c < 3; c++)
                {
                    for (int i = 0; i < tamanhoLenght - 1; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("||||");
                }
                tamanhoEspacos = 10;
                Thread.Sleep(250);
                Console.Clear();
            }
        }

        public static void CalculateAverage()
        {
            var listaAlunos = new List<double>();
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Digite a nota do aluno {i + 1}: ");
                listaAlunos.Add(double.Parse(Console.ReadLine()));
            }
            var notaFinal = FinalGrade(listaAlunos);
            Console.Clear();
            for (int i = 0; i < listaAlunos.Count; i++)
                Console.WriteLine($"Nota {i + 1}: {listaAlunos[i]}");
            Console.WriteLine($"Nota Final: {notaFinal}");
            Console.WriteLine(ReturnStringOfSituation(notaFinal));
        }

        private static double FinalGrade(List<double> lista)
        {
            var nota = 0.0;
            lista.ForEach(i => nota += i);
            return nota / lista.Count;
        }

        private static string ReturnStringOfSituation(double nota) => ReturnSituation(nota) ? "Aluno Aprovado" : "Aluno Reprovado";


        private static bool ReturnSituation(double nota) => nota >= 7;
    }
}
