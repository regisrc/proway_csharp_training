using System;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            app();
        }

        private static string returnText() => @"nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";

        private static bool verifyAgeAbove18(string idade) => Convert.ToByte(idade) >= 18;

        private static void app()
        {
            var pessoas = openText(returnText());
            var temp = "";
            foreach (var item in pessoas)
            {
                foreach (var itemAbrang in item.Split(','))
                {
                    if (itemAbrang.Split(':')[0] == "nome")
                        temp = itemAbrang.Split(':')[1];
                    if (itemAbrang.Split(':')[0] == "idade")
                        if (verifyAgeAbove18(itemAbrang.Split(':')[1]))
                            Console.WriteLine($" Nome: {temp} \n\r Idade: {itemAbrang.Split(':')[1]}");
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static string[] openText(string array)
        {
            var principal = new string[0];
            var textoSemPV = array.Split(';');
            return textoSemPV;
        }
    }

}
