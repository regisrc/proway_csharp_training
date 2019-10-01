using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Executa();
            Console.ReadKey();
        }

        private static void Executa()
        {
            DateTime current = DateTime.Now;
            List<int> lista = new List<int>();
            for (int i = 2; i < 9999999; i++)
            {
                if (i % 2 == 0) continue;
                else
                {
                    bool isPrime = true;
                    for (int j = 3; j < i / 2; j++)
                    {
                        if (VerificaPrimo(i, j))
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime) lista.Add(i);
                }
            }
            Console.WriteLine(DateTime.Now - current);
        }

        private static bool VerificaPrimo(int primeiroNumero, int segundoNumero) => primeiroNumero % segundoNumero == 0;
    }
}
