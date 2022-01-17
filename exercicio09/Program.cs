using System;

namespace exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorA;
            int valorB;

            Console.WriteLine("Insira o primeiro valor:");
            valorA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o segundo valor:");
            valorB = Convert.ToInt32(Console.ReadLine());

            if (valorA > valorB)
            {
                Console.WriteLine("A ordem crescente é: " +valorB );
                Console.WriteLine(+valorA);
            }
            else
            {
                Console.WriteLine("A ordem cescente é: " +valorA );
                Console.WriteLine(+valorB);
            }
        }
    }
}
