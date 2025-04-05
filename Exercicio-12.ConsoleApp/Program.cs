namespace Exercicio_12.ConsoleApp
{
   
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Números ímpares entre 100 e 200:");

                // Loop de 100 a 200
                for (int i = 100; i <= 200; i++)
                {
                    // Verifica se o número é ímpar
                    if (i % 2 != 0)
                    {
                        Console.Write($"- {i} ");
                    }
                }
            }
        }
    
}
