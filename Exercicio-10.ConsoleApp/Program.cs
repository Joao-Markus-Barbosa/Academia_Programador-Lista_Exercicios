namespace Exercicio_10.ConsoleApp
{
    
        internal class Program
        {
            static void Main(string[] args)
            {
                bool continuar = true;

                while (continuar)
                {
                    Console.Clear(); // Limpa a tela a cada nova execução
                    Console.WriteLine("=== Calculadora de IMC ===");

                    // Validação de entrada para peso
                    double kg;
                    do
                    {
                        Console.Write("Digite seu peso em kg (ex: 70,5): ");
                    } while (!double.TryParse(Console.ReadLine(), out kg) || kg <= 0);

                    // Validação de entrada para altura
                    double cm;
                    do
                    {
                        Console.Write("Digite sua altura em cm (ex: 175): ");
                    } while (!double.TryParse(Console.ReadLine(), out cm) || cm <= 0);

                    double metros = cm / 100;
                    double imc = kg / (metros * metros);

                    // Classificação do IMC (agora com enumeração)
                    string classificacao;
                    if (imc < 18.5)
                        classificacao = "Abaixo do peso";
                    else if (imc < 25)
                        classificacao = "Peso ideal";
                    else if (imc < 30)
                        classificacao = "Acima do peso";
                    else
                        classificacao = "Obesidade";

                    Console.WriteLine($"\nSeu IMC é: {imc:F1} - {classificacao}");

                    // Controle de repetição com validação
                    Console.Write("\nCalcular novamente? (S/N): ");
                    continuar = Console.ReadLine().Trim().ToUpper() == "S";
                }

                Console.WriteLine("\nPrograma encerrado. Pressione qualquer tecla...");
                Console.ReadKey();
            }
        }
    
}
