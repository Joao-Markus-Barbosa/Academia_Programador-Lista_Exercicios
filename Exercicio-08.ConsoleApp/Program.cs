namespace Exercicio_08.ConsoleApp
{
   
        class Program
        {
            static void Main()
            {
                Console.WriteLine("Verifica se A + B é menor que C\n");

                while (true)
                {
                    Console.Write("Digite A: ");
                    double a = LerNumero();

                    Console.Write("Digite B: ");
                    double b = LerNumero();

                    Console.Write("Digite C: ");
                    double c = LerNumero();

                    double soma = a + b;


                    if (soma < c)
                    {
                        Console.WriteLine($"{a} + {b} = {soma} < {c} (A+B é menor)");
                    }
                    else
                    {
                        Console.WriteLine($"{a} + {b} = {soma} ≥ {c} (A+B não é menor)");
                    }

                    Console.Write("\nContinuar? (S/N): ");
                    if (Console.ReadLine().ToUpper() != "S") break;
                    Console.WriteLine();
                }
            }

            static double LerNumero()
            {
                while (true)
                {
                    if (double.TryParse(Console.ReadLine(), out double numero))
                        return numero;

                    Console.Write("Valor inválido. Digite novamente: ");
                }
            }
        }
    
}
