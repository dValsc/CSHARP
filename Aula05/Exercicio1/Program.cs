namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetorInteiros = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6};
            int numero;

            Array.Sort(vetorInteiros);

            Console.WriteLine("Digite o número que deseja encontar: ");
            numero = Convert.ToInt32(Console.ReadLine());

            int posicao = Array.BinarySearch(vetorInteiros, numero);

            if (posicao>=0)
                Console.WriteLine($"O número {numero} está localizado na posição: {posicao}");
            else
                Console.WriteLine($"O número {numero} não foi encontrado!");

        }
    }
}