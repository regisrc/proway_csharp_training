using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class AnimacoesEmFrames
    {
        public void PrintTree()
        {
            var caracter = "/";
            var caracterCresce = $"\\";
            var tamanhoLenght = 10;
            var tamanhoEspacos = 10;
            Random randNum = new Random();
            for (int z = 0; z < 20; z++)
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
    }
}
