namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, soma = 0;
            do
            {
                Console.Write("Digite um numero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero >0)
                {
                    soma = soma + numero;
                }
            } while  (numero != 0);

            Console.WriteLine($"A soma dos numeros positivos é: {soma}");
        }
    }
}