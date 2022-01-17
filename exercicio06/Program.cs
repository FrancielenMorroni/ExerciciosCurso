using System;

namespace exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maça;
            double preço = 1.30;
            double preçoduz = 1;
            double total;
           
            Console.WriteLine("Quantas maçãs você deseja comprar?");
            maça = Convert.ToDouble (Console.ReadLine());

            if (maça < 12)
            {
                total = maça * preço;
                Console.WriteLine("O valor da sua compra, em reais, é de:" + total);
            }
            if (maça >= 12)
            {
                total = maça * preçoduz;
                Console.WriteLine("O valor da sua compra, em reais, é de:" + total);
            }
            Console.WriteLine("Favor dirigir-se até o caixa para efetuar o pagamento.");

        }
    }
}
