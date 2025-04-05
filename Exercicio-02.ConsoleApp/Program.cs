namespace Exercicio_02.ConsoleApp
{
        internal class Program
        {
            static void Main(string[] args)
            {
                bool continuar = true;

                while (continuar)
                {
                    Console.Clear();
                    Console.WriteLine("=== CÁLCULO DO VOLUME DO CILINDRO ===");


                    Console.Write("Digite o raio do cilindro: ");
                    double raio = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite a altura do cilindro: ");
                    double altura = Convert.ToDouble(Console.ReadLine());

                    double volumeCilindro = Math.PI * Math.Pow(raio, 2) * altura;
                    Console.WriteLine($"\nVolume do cilindro: {volumeCilindro:F2}");

                    // Pergunta se deseja continuar
                    Console.Write("\nDeseja calcular outro volume? (S/N): ");
                    string resposta = Console.ReadLine().ToUpper();
                    continuar = (resposta == "S");
                }

                Console.WriteLine("\nPrograma encerrado. Obrigado!");
            }
        }
    

}
