namespace Exercicio_13.ConsoleApp
{
    
        internal class Program
        {
            static void Main(string[] args)
            {

                bool continuar = true;

                Console.Write("Digite um número inteiro não negativo: ");
                int n = int.Parse(Console.ReadLine());

                if (n < 0)
                {
                    Console.WriteLine("Fatorial não está definido para números negativos!");
                }
                else
                {
                    long fatorial = 1; // long para evitar overflow com números grandes

                    for (int i = 1; i <= n; i++)
                    {
                        fatorial *= i;
                    }

                    Console.WriteLine($"{n}! = {fatorial}");

                    Console.Write("\nDeseja realizar outra consulta? (S/N): ");
                    continuar = Console.ReadLine().ToUpper() == "S";
                }
            }
        }
    
}
