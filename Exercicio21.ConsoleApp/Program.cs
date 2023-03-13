namespace Exercicio21.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            Console.WriteLine("Digite o valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            B = Convert.ToInt32(Console.ReadLine());

            if (A == B)
            {
                C = A + B;
            }
            else
            {
                C = A * B;
            }

            Console.WriteLine("O resultado é: " + C);
        }
    }
}
