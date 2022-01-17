using System;

namespace exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorA;
            int valorB;

            Console.WriteLine("Insira o valor A:");
            valorA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor de B");
            valorB = Convert.ToInt32(Console.ReadLine());

            if (valorA > valorB)
            {
                Console.WriteLine("O maior valor é: " +valorA);
            }
            else
            {
                Console.WriteLine("O maior valor é: " +valorB);
            }
        }
    }
}
