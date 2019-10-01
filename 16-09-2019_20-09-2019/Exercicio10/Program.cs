using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            app();
        }

        private static void app()
        {
            Console.Write("Informe um veiculo: ");
            var carroEscolhido = Console.ReadLine();

            var carros = "carro:Gol,marca:volkswagen,ano:2000;carro:Jetta,marca:volkswagen,ano:2012;carro:Sportage,marca:Kia,ano:2011;carro:Hb20,marca:hyundai,ano:2015";
            foreach (var carro in returnCars(carros))
            {
                if (carroEscolhido == carro.Split(',')[0].Split(':')[1])
                {
                    foreach (var item in returnCarsInfos(carro))
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }

        private static string[] returnCars(string carros) => carros.Split(';');

        private static string[] returnCarsInfos(string carros) => carros.Split(',');
    }
}
