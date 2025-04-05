namespace Exercicio_01.ConsoleApp


{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== CÁLCULO DO VOLUME DE CAIXA RETANGULAR ===");

                // Mantendo todo o código original exatamente como estava
                Console.Write("Digite o comprimento da caixa (em metros ou centímetros): ");
                double comprimento = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a largura da caixa (em metros ou centímetros): ");
                double largura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a altura da caixa (em metros ou centímetros): ");
                double altura = Convert.ToDouble(Console.ReadLine());

                double volume = comprimento * largura * altura;

                Console.WriteLine($"\nO volume da caixa retangular é: {volume}");

                // Pergunta se deseja continuar
                Console.Write("\nDeseja calcular outro volume? (S/N): ");
                string resposta = Console.ReadLine().Trim().ToUpper();
                continuar = (resposta == "S");
            }

            Console.WriteLine("\nPrograma encerrado. Obrigado!");
        }
    }
}
