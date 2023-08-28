namespace EXERCICIO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[,] matriz01 = new float[10, 4];
            float[] vetorMedia = new float[10];

            for (int linha = 0; linha < matriz01.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz01.GetLength(1); coluna++)
                {
                    Console.WriteLine($"Digite um valor para a posição [{linha}, {coluna}]: ");
                    matriz01[linha, coluna] = float.Parse(Console.ReadLine());
                    Console.Clear();
                }
            }

            for (int linha = 0; linha < matriz01.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz01.GetLength(1); coluna++)
                {
                    vetorMedia[linha] += matriz01[linha, coluna]/4 ;
                }

            }

            for (int linha = 0; linha < matriz01.GetLength(0); linha++)
            {
                Console.WriteLine( $"media de todos os elementos da linha ({linha + 1}) é: {vetorMedia[linha]:F1}");
            }
        }
    }
}