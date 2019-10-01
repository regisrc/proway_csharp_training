using System;
using System.Collections.Generic;
using System.Globalization;

namespace ForEachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeDecimais();
        }

        private static void ListaDateTime()
        {
            var minhaLista = new List<DateTime>();

            minhaLista.Add(new DateTime(2019,9,17));
            minhaLista.Add(new DateTime(2019,9,18));
            minhaLista.Add(new DateTime(2019,9,19));
            minhaLista.Add(new DateTime(2019,9,20));
            minhaLista.Add(new DateTime(2019,9,21));

            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData));

        }

        private static void listaString()
        {
            var minhaLista = new List<string>();
            minhaLista.Add("Xiaomi");
            minhaLista.Add("Iphone Apple");
            minhaLista.Add("Samsung");
            minhaLista.Add("Nokia");

            minhaLista.ForEach(i => Console.WriteLine(i));
        }

        private static void listaInt()
        {
            var minhaLista = new List<int>();
            minhaLista.Add(1);
            minhaLista.Add(2);
            minhaLista.Add(3);
            minhaLista.Add(4);

            minhaLista.ForEach(i => Console.WriteLine(FormatDecimalNumberInDolar(Convert.ToDouble(i))));
        }
        /// <summary>
        /// Metodo que converte meu numero real em Dolar
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        private static string FormatDecimalNumberInDolar(double numero) => numero.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        /// <summary>
        /// Metodo que converte meu numero real em Ien
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        private static string FormatDecimalNumberInIen(double numero) => numero.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"));
        /// <summary>
        /// Metodo que converte meu numero real em Euro
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        private static string FormatDecimalNumberInEuro(double numero) => numero.ToString("C", CultureInfo.CreateSpecificCulture("it-IT"));

        /// <summary>
        /// Metodo que converte meu numero real em BitCoin
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        private static string ChangeToBtc(double numero) => (numero / 41989.28).ToString("C10",CultureInfo.CreateSpecificCulture("en-US")).Replace("$","BTC ");

        private static void ListaDeDecimais()
        {
            var minhaLista = new List<double>();
            minhaLista.Add(1.02);
            minhaLista.Add(2.64);
            minhaLista.Add(3.89);
            minhaLista.Add(4.785);

            minhaLista.ForEach(i => Console.WriteLine(ChangeToBtc(i)));

        }

    }
}
