namespace Exercicio_14.ConsoleApp
{
        internal class Program
        {
            static void Main(string[] args)
            {

                Console.Write("Digite um número limite para a sequência de Fibonacci: ");
                int limite = int.Parse(Console.ReadLine());

                Console.WriteLine($"Sequência de Fibonacci até {limite}:");

                long a = 0, b = 1;

                // Caso especial para 0
                if (limite >= 0)
                {
                    Console.Write(a + " ");
                }

                while (b <= limite)
                {
                    Console.Write(b + " ");
                    long proximo = a + b;
                    a = b;
                    b = proximo;

                }

            }
        }
    

}
