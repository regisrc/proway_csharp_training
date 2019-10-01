using System;
using System.Globalization;

namespace MetodosPublicos
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConversorMonetarioSis();
        }


        public static void ConversorMonetarioSis()
        {
            Console.WriteLine("---Sistema para conversão de moedas cabuloso---");
            Console.Write("Infome um valor a ser convertido: ");
            var valor = Console.ReadLine();
            
            Console.Clear();
            Console.Write("Infome uma moeda para conversão: ");
            var moeda = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Conversão realizada: ");
            Console.WriteLine(ConverteMoeda(Convert.ToInt32(valor), moeda.ToUpper()));
        }
        /// <summary>
        /// Metodo que converte moeda em real para um alvo especificado
        /// para converte digite os alvos: 
        /// - "EURO"
        /// - "YEN"
        /// - "BTC"
        /// - "DOLAR"
        /// </summary>
        /// <param name="minhaMoeda">Moeda em valor real</param>
        /// <param name="moedaAlvo">Alvo em que a moeda será convertida</param>
        public static string ConverteMoeda(double minhaMoeda, string moedaAlvo) => (minhaMoeda * FormataNumeroDecimalEmDinheiro(minhaMoeda, moedaAlvo)).ToString("C5", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", $"{moedaAlvo} ");

        public static double FormataNumeroDecimalEmDinheiro(double moeda, string moedaAlvo)
        {
            switch (moedaAlvo)
            {
                case "DOLAR": return 0.24; break;
                case "EURO": return 0.22; break;
                case "IEN": return 26.42; break;
                case "BTC": return 0.000024; break;
                default: return 0; break;
            }
        }
    }
}
