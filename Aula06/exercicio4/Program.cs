namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilhalivros = new Stack<string>();

            int opcao = 1;


            while (opcao != 0)
            {
                Console.WriteLine("********************** Menu **********************");
                Console.WriteLine("\n--1: Adicionar Livro na pilha.--");
                Console.WriteLine("--2: Listar todos os Livros--");
                Console.WriteLine("--3: Retirar Livro da pilha--");
                Console.WriteLine("--0: Sair. --\n");
                Console.WriteLine("**************************************************");

                Console.WriteLine("Entre com a opção desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {

                    case 1:

                        Console.WriteLine("Digite o nome do livro:");

                        pilhalivros.Push(Console.ReadLine());

                        Console.WriteLine("Livro Adicionado!\n");

                        break;
                    case 2:
                        foreach (var livro in pilhalivros)
                        {
                            Console.WriteLine(livro);
                        }
                        break;
                    case 3:

                        if (pilhalivros.Count > 0)
                        {
                            pilhalivros.Pop();

                            Console.WriteLine("Livro retirado!\n");
                            foreach (var livro in pilhalivros)
                            {
                                Console.WriteLine(livro);
                            }
                        }
                        else
                        {
                            Console.WriteLine("A pilha está vazia!\n");
                        }

                        break;
                    case 0:

                        Console.WriteLine("Programa Finalizado!");

                        break;
                    default:
                        Console.Write("Opção inválida!\n");
                        break;
                }


            }
        }
    }
}