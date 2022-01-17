using System;

namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            a = b;
            b = a - 10;
            
            Console.WriteLine("O valor armazenado em a é:" +a);
            Console.WriteLine("O valor armazenado em b é:" +b);


        }
    }
}
