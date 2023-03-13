using System;

namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal temperaturaFahrenheit, temperaturaCelsius;

            Console.WriteLine("Digite a temperatura em graus Fahrenheit: ");
            temperaturaFahrenheit = Convert.ToDecimal(Console.ReadLine());

            temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;

            Console.WriteLine("A temperatura em graus Celsius é: " + temperaturaCelsius);

            Console.ReadLine();
        }
    }
}