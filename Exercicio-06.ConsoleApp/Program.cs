namespace Exercicio_06.ConsoleApp
{
    
        internal class Program
        {
            static void Main(string[] args)
            {
                bool continuar = true;

                while (continuar)
                {
                    Console.Clear();
                    Console.WriteLine("=== CÁLCULO DE MÉDIA PONDERADA ===");

                    // Entrada de dados
                    Console.Write("Digite a nota da primeira prova: ");
                    double nota1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o peso da primeira prova: ");
                    double peso1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite a nota da segunda prova: ");
                    double nota2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o peso da segunda prova: ");
                    double peso2 = Convert.ToDouble(Console.ReadLine());

                    // Cálculo da média ponderada
                    double somaPesos = peso1 + peso2;
                    double mediaPonderada = (nota1 * peso1 + nota2 * peso2) / somaPesos;

                    // Exibição do resultado
                    Console.WriteLine($"\nMédia Ponderada: {mediaPonderada:F2}");

                    // Pergunta se deseja continuar
                    Console.Write("\nDeseja calcular outra média? (S/N): ");
                    string resposta = Console.ReadLine().Trim().ToUpper();
                    continuar = (resposta == "S");
                }

                Console.WriteLine("\nPrograma encerrado. Obrigado!");
            }
        }
    
}
