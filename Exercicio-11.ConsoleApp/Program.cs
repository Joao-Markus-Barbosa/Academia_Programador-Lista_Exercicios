namespace Exercicio_11.ConsoleApp
{
  
        internal class Program
        {
            static void Main(string[] args)
            {

                bool continuar = true;

                while (continuar)
                {
                    Console.WriteLine("Programa para informar se número é ímpar ou par");

                    double nr;
                    do
                    {
                        Console.Write("Digite número: ");
                    } while (!double.TryParse(Console.ReadLine(), out nr) || nr <= 0);


                    double resultado = nr % 2;

                    if (resultado == 0)
                    {
                        Console.WriteLine($"O número digitado {nr} é par!");
                    }
                    else if (resultado == 1)
                    {
                        Console.WriteLine($"O número digitado {nr} é ímpar");
                    }

                    Console.Write("\nDeseja realizar outra consulta? (S/N): ");
                    continuar = Console.ReadLine().Trim().ToUpper() == "S";

                }

            }
        }
    

}
