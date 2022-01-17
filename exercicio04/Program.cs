using System;

namespace exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Insira um valor:");
            a = Convert.ToInt32 (Console.ReadLine());

            if (a > 10)
            {
                Console.WriteLine("É MAIOR QUE 10!");
            }

            else
            {
                Console.WriteLine("NÃO É MAIOR QUE 10!");
            }
        }
    }
}
