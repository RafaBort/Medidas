using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma medida em metro...");
            string metros;
            metros = Console.ReadLine();

            Double medidas1 = Convert.ToDouble(metros);
            Double CM = 100;
            Double KM = 1000;

            Double multiplicacao = medidas1 * CM;
            Double igual = medidas1;
            Double divisao = medidas1 / KM;

            Console.WriteLine("em cm" + " " + multiplicacao);
            Console.WriteLine("em metros" + " " + igual);
            Console.WriteLine("em km" + " " + divisao);

        }
    }
}
