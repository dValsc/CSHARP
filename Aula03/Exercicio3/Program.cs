namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            String produto ="";
            int codproduto;
            float quantidade, preco =0;


            Console.WriteLine("Digite o código do produto: ");
            codproduto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quatidade: ");
            quantidade = Convert.ToSingle(Console.ReadLine());

            switch (codproduto)
            {
                case 1:
                    preco = quantidade * 10;
                    produto = "Cachorro Quente";
                    break;
                case 2:
                    preco = quantidade * 15;
                    produto = "X - Salada";
                    break;
                case 3:
                    preco = quantidade * 18;
                    produto = "X - Bacon";
                    break;
                case 4:
                    preco = quantidade * 12;
                    produto = "Bauru";
                    break;
                case 5:
                    preco = quantidade * 8;
                    produto = "Refrigerante";
                    break;
                case 6:
                    preco = quantidade * 13;
                    produto = "Suco de Laranja";
                    break;
            }
            Console.WriteLine($"Produto: {produto} ");
            Console.WriteLine($"Valor total: {preco}");
        }
    }
}