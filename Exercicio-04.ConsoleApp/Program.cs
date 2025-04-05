namespace Exercicio_04.ConsoleApp
{
    
        internal class Program
        {
            static void Main(string[] args)
            {
                bool continuar = true;

                while (continuar)
                {
                    Console.Clear();
                    Console.WriteLine("====================================");
                    Console.WriteLine("    CONVERSOR DE TEMPERATURA");
                    Console.WriteLine("====================================");
                    Console.WriteLine("1 - Celsius para Fahrenheit");
                    Console.WriteLine("2 - Fahrenheit para Celsius");
                    Console.WriteLine("3 - Celsius para Kelvin");
                    Console.WriteLine("4 - Kelvin para Celsius");
                    Console.WriteLine("5 - Fahrenheit para Kelvin");
                    Console.WriteLine("6 - Kelvin para Fahrenheit");
                    Console.WriteLine("0 - Sair");
                    Console.WriteLine("------------------------------------");

                    // Leitura da opção
                    int op;
                    Console.Write("Escolha a opção desejada (0-6): ");
                    while (!int.TryParse(Console.ReadLine(), out op) || op < 0 || op > 6)
                    {
                        Console.Write("Valor inválido! Digite um número entre 0 e 6: ");
                    }

                    if (op == 0)
                    {
                        continuar = false;
                        continue;
                    }

                    Console.WriteLine("\n------------------------------------");

                    try
                    {
                        switch (op)
                        {
                            case 1:
                                Console.Write("Informe a temperatura em Celsius: ");
                                double celsiusToFahr = Convert.ToDouble(Console.ReadLine());
                                double resultFahrenheit = (celsiusToFahr * 1.8) + 32;
                                Console.WriteLine($"\n{celsiusToFahr:F2}°C = {resultFahrenheit:F2}°F");
                                break;

                            case 2:
                                Console.Write("Informe a temperatura em Fahrenheit: ");
                                double fahrToCelsius = Convert.ToDouble(Console.ReadLine());
                                double resultCelsius = (fahrToCelsius - 32) / 1.8;
                                Console.WriteLine($"\n{fahrToCelsius:F2}°F = {resultCelsius:F2}°C");
                                break;

                            case 3:
                                Console.Write("Informe a temperatura em Celsius: ");
                                double celsiusToKelvin = Convert.ToDouble(Console.ReadLine());
                                if (celsiusToKelvin < -273.15)
                                    throw new ArgumentException("O zero absoluto é -273.15°C!");
                                double resultKelvinFromC = celsiusToKelvin + 273.15;
                                Console.WriteLine($"\n{celsiusToKelvin:F2}°C = {resultKelvinFromC:F2}K");
                                break;

                            case 4:
                                Console.Write("Informe a temperatura em Kelvin: ");
                                double kelvinToCelsius = Convert.ToDouble(Console.ReadLine());
                                if (kelvinToCelsius < 0)
                                    throw new ArgumentException("Kelvin não pode ser negativo!");
                                double resultCelsiusFromK = kelvinToCelsius - 273.15;
                                Console.WriteLine($"\n{kelvinToCelsius:F2}K = {resultCelsiusFromK:F2}°C");
                                break;

                            case 5:
                                Console.Write("Informe a temperatura em Fahrenheit: ");
                                double fahrToKelvin = Convert.ToDouble(Console.ReadLine());
                                if (fahrToKelvin < -459.67)
                                    throw new ArgumentException("O zero absoluto é -459.67°F!");
                                double resultKelvinFromF = (fahrToKelvin - 32) * 5 / 9 + 273.15;
                                Console.WriteLine($"\n{fahrToKelvin:F2}°F = {resultKelvinFromF:F2}K");
                                break;

                            case 6:
                                Console.Write("Informe a temperatura em Kelvin: ");
                                double kelvinToFahr = Convert.ToDouble(Console.ReadLine());
                                if (kelvinToFahr < 0)
                                    throw new ArgumentException("Kelvin não pode ser negativo!");
                                double resultFahrFromK = (kelvinToFahr - 273.15) * 9 / 5 + 32;
                                Console.WriteLine($"\n{kelvinToFahr:F2}K = {resultFahrFromK:F2}°F");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\nErro: {ex.Message}");
                    }

                    if (op != 0)
                    {
                        Console.WriteLine("\n------------------------------------");
                        Console.Write("Deseja fazer outra conversão? (S/N): ");
                        string resposta = Console.ReadLine().ToUpper();
                        continuar = (resposta == "S");
                    }
                }

                Console.WriteLine("\nPrograma encerrado.");
            }
        }
    
}
