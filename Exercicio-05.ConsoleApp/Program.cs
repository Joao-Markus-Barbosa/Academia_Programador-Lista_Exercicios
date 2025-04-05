namespace Exercicio_05.ConsoleApp
{
    
        internal class Program
        {
            static void Main(string[] args)
            {
                bool continuar = true;

                while (continuar)
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------\n" +
                                      "Cálculo do salário do vendedor\n" +
                                      "------------------------------");

                    Console.Write("Informe o salário base do vendedor(a): ");
                    double salario = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Informe o total de vendas: ");
                    double vendas = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Informe o percentual a comissão de percentual por vendas: ");
                    double percentual = Convert.ToDouble(Console.ReadLine());

                    double salarioTotal = ((percentual / 100) * vendas) + salario;

                    Console.WriteLine($"Porcentagem por venda: {percentual}%");
                    Console.WriteLine($"Total a receber: {salarioTotal:F2}");

                    Console.Write("\nDeseja calcular para outro vendedor? (S/N): ");
                    string resposta = Console.ReadLine().ToUpper();

                    continuar = (resposta == "S");
                }

                Console.WriteLine("\nPrograma encerrado. Pressione qualquer tecla para sair...");
                Console.ReadKey();
            }
        }
    
}
