namespace Exercicio_07.ConsoleApp
{
   
        internal class Program
        {
            static void Main()
            {

                bool continuar = true;


                while (continuar)
                {


                    Console.WriteLine("Digite um número para verificar se é primo:");
                    int num = int.Parse(Console.ReadLine());

                    if (EhPrimo(num))
                        Console.WriteLine($"{num} é um número primo! 🎉");
                    else
                        Console.WriteLine($"{num} NÃO é um número primo. 😢");

                    // Pergunta se deseja continuar
                    Console.Write("\nDeseja calcular outro volume? (S/N): ");
                    string resposta = Console.ReadLine().ToUpper();
                    continuar = (resposta == "S");
                }

            }

            static bool EhPrimo(int numero)
            {
                if (numero <= 1)
                    return false; // Números ≤ 1 não são primos

                if (numero == 2)
                    return true; // 2 é o único primo par

                if (numero % 2 == 0)
                    return false; // Números pares > 2 não são primos

                // Verifica divisores ímpares até a raiz quadrada do número
                for (int i = 3; i <= Math.Sqrt(numero); i += 2)
                {
                    if (numero % i == 0)
                        return false;
                }

                return true;
            }

        }
    
}
