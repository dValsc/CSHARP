using classeproduto.Modelproduto;

namespace classeproduto
{
    public class Program
    {
        private static ConsoleKeyInfo ConsoleKeyInfo;
        static void Main(string[] args)
        {
            int opcao;

            Produto regs1 = new Produto("Celular", 1, "Nokia", "AB1", 5, "Trânsito");

            regs1.Visualizar();

            Produto regs2 = new Produto("TV", 2, "AOC", "AB2", 2, "Vendido");

            regs2.Visualizar();


            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("******************************************************");
                Console.WriteLine("                                                      ");
                Console.WriteLine("                       PRODUTOS                       ");
                Console.WriteLine("                                                      ");
                Console.WriteLine("******************************************************");
                Console.WriteLine("                                                      ");
                Console.WriteLine("                 1 - Cadastrar Produto                ");
                Console.WriteLine("                 2 - Listar todos os produtos         ");
                Console.WriteLine("                 3 - Buscar Produto                   ");
                Console.WriteLine("                 4 - Atualizar Dados do produto       ");
                Console.WriteLine("                 5 - Apagar Produto                   ");
                Console.WriteLine("                 6 - Sair                             ");
                Console.WriteLine("                                                      ");
                Console.WriteLine("******************************************************");
                Console.WriteLine("Entre com a opção desejada:                           ");
                Console.WriteLine("                                                      ");
                Console.ResetColor();

                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 6)
                {
                    Sobre();
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Cadastrar Produto\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 2:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Listar todos os produtos\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 3:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Buscar Produto\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 4:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Atualizar Dados do produto\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 5:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Apagar Produto\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;

                    default:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nOpção Inválida!\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                }
            }

            static void Sobre()
            {
                Console.WriteLine("\n*********************************************************");
                Console.WriteLine("Projeto Desenvolvido por: Valéria Carvalho");
                Console.WriteLine("E-mail: valeria.dcarvalho@hotmail.com");
                Console.WriteLine("github.com/dValsc");
                Console.WriteLine("*********************************************************");
            }

            static void KeyPress()
            {
                do
                {
                    Console.Write("\nPressione Enter para Continuar...");
                    ConsoleKeyInfo = Console.ReadKey();
                } while (ConsoleKeyInfo.Key != ConsoleKey.Enter);
            }

        }
    }
}