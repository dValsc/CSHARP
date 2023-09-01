using Classe_Cliente.ModelCliente;

namespace Classe_Cliente
{
    public class Program
    {
        private static ConsoleKeyInfo ConsoleKeyInfo;
        static void Main(string[] args)
        {
            int opcao;

            Cliente regs1 = new Cliente("Ana", 1, "rua a, nº12, SP", 123456789, 121587633-66, "Acompanhando");

            regs1.Visualizar();

            Cliente regs2 = new Cliente("Vania", 2, "rua b, nº13, RJ", 987654321, 789321546-66, "Finalizado");

            regs2.Visualizar();

            PessoaFisica pf1 = new PessoaFisica("Ana", 1, "rua a, nº12, SP", 123456789, 121587633 - 66, "Acompanhando",24);

            pf1.Visualizar();

            Cliente pf2 = new PessoaFisica("Vania", 2, "rua b, nº13, RJ", 987654321, 789321546 - 66, "Finalizado",36);

            pf2.Visualizar();

            PessoaJuridica pj1 = new PessoaJuridica("Ana", 1, "rua a, nº12, SP", 123456789, 121587633 - 66, "Acompanhando", "Não");

            pf1.Visualizar();

            PessoaJuridica pj2 = new PessoaJuridica("Vania", 2, "rua b, nº13, RJ", 987654321, 789321546 - 66, "Finalizado", "Sim");

            pf2.Visualizar();


            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("******************************************************");
                Console.WriteLine("                                                      ");
                Console.WriteLine("                 CLIENTES - PROSPECÇÃO                ");
                Console.WriteLine("                                                      ");
                Console.WriteLine("******************************************************");
                Console.WriteLine("                                                      ");
                Console.WriteLine("                 1 - Cadastrar Cliente                ");
                Console.WriteLine("                 2 - Listar todos os clientes         ");
                Console.WriteLine("                 3 - Buscar Cliente por ID            ");
                Console.WriteLine("                 4 - Atualizar Dados do Cliente       ");
                Console.WriteLine("                 5 - Apagar Cliente                   ");
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
                        Console.WriteLine("Cadastrar Cliente\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 2:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Listar todos os clientes\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 3:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Buscar Cliente por ID\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 4:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Atualizar Dados do Cliente\n\n");
                        Console.ResetColor();

                        KeyPress();
                        break;
                    case 5:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Apagar Cliente\n\n");
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