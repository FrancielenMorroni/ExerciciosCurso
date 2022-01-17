using System;

namespace exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1;
            double nota2;
            double media;

            Console.WriteLine("Bem vindo. Para saber o resultado, favor inserir o valor da nota da primeira avaliação:");
            nota1 = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("Agora, insira o valor da nota da segunda avaliação");
            nota2 = Convert.ToDouble (Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if (media >= 6)
            {
                Console.WriteLine("O aluno foi aprovado");
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado");
            }
            Console.WriteLine("A media do aluno foi:" + media);
        }
    }
}
