namespace Exercicio23.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 101; i <= 199; i += 2)
            {
                int numeroImpar = Convert.ToInt32(i);
                Console.WriteLine(numeroImpar);
            }

            Console.ReadLine();
        }
    }
}