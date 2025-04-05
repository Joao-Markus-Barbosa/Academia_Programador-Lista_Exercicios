namespace Exercicio_03.ConsoleApp
{
    
        internal class Program
        {
            static void Main(string[] args)
            {
                bool repetir = true;

                while (repetir)
                {
                    Console.Clear();
                    Console.WriteLine("=== CÁLCULO DE CONSUMO DE COMBUSTÍVEL ===");

                    // Código original exatamente como você tinha
                    Console.Write("Informe a quilometragem inicial do veículo no início da viagem: ");
                    double kmInicial = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Informe a quilometragem final ao término da viagem: ");
                    double kmFinal = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Informe a quantidade de combustível consumida durante a viagem (em litros): ");
                    double qtCombustivel = Convert.ToDouble(Console.ReadLine());

                    double kmPercorrido = kmFinal - kmInicial;
                    double consumoPorKm = qtCombustivel / kmPercorrido;

                    Console.WriteLine($"\nDistância percorrida: {kmPercorrido:F2} km");
                    Console.WriteLine($"Combustível consumido: {qtCombustivel:F2} litros");
                    Console.WriteLine($"Consumo por quilômetro: {consumoPorKm:F4} litros/km");

                    double kmPorLitro = kmPercorrido / qtCombustivel;
                    Console.WriteLine($"Consumo: {kmPorLitro:F2} km/l");

                    // Pergunta se deseja repetir
                    Console.Write("\nDeseja realizar outro cálculo? (S/N): ");
                    string resposta = Console.ReadLine().ToUpper();
                    repetir = (resposta == "S");
                }

                Console.WriteLine("\nPrograma encerrado. Obrigado!");
            }
        }
    

}
