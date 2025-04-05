namespace Exercicio_09.ConsoleApp
{

        class Program
        {
            static void Main()
            {
                Console.WriteLine("Ordena três números diferentes em ordem decrescente\n");

                while (true)
                {
                    Console.Write("Digite o primeiro número: ");
                    int a = LerNumero();

                    Console.Write("Digite o segundo número: ");
                    int b = LerNumero();

                    Console.Write("Digite o terceiro número: ");
                    int c = LerNumero();

                    // Verifica se os números são diferentes
                    if (a == b || a == c || b == c)
                    {
                        Console.WriteLine("Erro: Os números devem ser diferentes!");
                        continue;
                    }

                    // Ordenação decrescente
                    if (a < b)
                    {
                        int temp = a;
                        a = b;
                        b = temp;
                    }
                    if (a < c)
                    {
                        int temp = a;
                        a = c;
                        c = temp;
                    }
                    if (b < c)
                    {
                        int temp = b;
                        b = c;
                        c = temp;
                    }

                    Console.WriteLine($"\nOrdem decrescente: {a}, {b}, {c}");

                    Console.Write("\nDeseja ordenar outros números? (S/N): ");
                    if (Console.ReadLine().ToUpper() != "S") break;
                    Console.WriteLine();
                }
            }

            static int LerNumero()
            {
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out int numero))
                        return numero;

                    Console.Write("Valor inválido. Digite um número inteiro: ");
                }
            }
        }

    
}
