namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, Diferença;

            Console.WriteLine("Digite o número 1:");
            nota1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o número 2:");
            nota2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o número 3:");
            nota3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o número 4:");
            nota4 = Convert.ToSingle(Console.ReadLine());

            Diferença = (nota1 * nota2) - (nota3 * nota4);


            Console.WriteLine("Diferença: " + Diferença);
        }
    }
}