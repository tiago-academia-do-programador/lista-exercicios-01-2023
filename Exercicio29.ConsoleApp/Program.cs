﻿namespace Exercicio29.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int result = i * j;
                    Console.Write("{0} x {1} = {2}\n", i, j, result);
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}