using System;
using System.Globalization;

namespace testes_ec
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            char repetir;

            do
            {
                Console.Write("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = 9.0 * C / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahreinheit: " + F.ToString("F1", CultureInfo.InvariantCulture));
                Console.Write("Deseja repetir (s/n)? ");
                repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's');




            Console.ReadLine();
        }

    }

}