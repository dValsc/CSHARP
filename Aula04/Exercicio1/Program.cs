namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("Digite o primeiro numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 < numero2)
            {
                for (int contador = numero1; contador <= numero2; contador++) 
                { 
                if (contador % 3 ==0 && contador % 5 ==0)
                    {
                        Console.WriteLine($" {contador} é múltiplo de 3 e 5.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Intervalo inválido!");
            }

        }
    }
}