namespace Exercicio_15.ConsoleApp
{
   
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Programa que imprima os números de 1 a 100 em ordem crescente,\n" +
                    "substituindo os números múltiplos de 3 pela palavra Fizz e os múltiplos de 5 pela palavra Buzz.\n" +
                    "Para números que são múltiplos de ambos, é adicionado a palavra FizzBuzz.\n\n\n");

                for (int i = 1; i <= 100; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine($" {i} ");
                    }
                }
            }
        }
    
}
