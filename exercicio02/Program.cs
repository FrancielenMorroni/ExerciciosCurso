using System;

namespace exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Favor digitar um valor:");
            a = Convert.ToInt32 (Console.ReadLine());

            b = a - 1;
         
          Console.WriteLine("O antecessor do valor inserido é:" +b);

        }
    }
}
