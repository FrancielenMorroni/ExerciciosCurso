using System;

namespace exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Digite um valor:");
            a = Convert.ToInt32(Console.ReadLine());

            if (a >= 0)
            {
                Console.WriteLine("O valor é positivo");
            }
            else
            {
                Console.WriteLine("O valor é negativo");
            }
        }
    }
}
