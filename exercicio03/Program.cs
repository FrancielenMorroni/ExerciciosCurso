using System;

namespace exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Escreva o valor da base do retângulo");
            a = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Escreva o valor da altura do retângulo");
            b = Convert.ToInt32 (Console.ReadLine());

            c = a * b;

            Console.WriteLine("o resultado da área do retangulo é:" +c);

        }
    }
}
