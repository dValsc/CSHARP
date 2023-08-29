using System;

namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();

            int opcao =1;


            while (opcao != 0)
            {
                Console.WriteLine("********************** Menu **********************");
                Console.WriteLine("\n--1: Adicionar um novo Cliente na fila.--");
                Console.WriteLine("--2: Listar todos os Clientes na fila--");
                Console.WriteLine("--3: Chamar uma pessoa da fila--");
                Console.WriteLine("--0: Sair. --\n");
                Console.WriteLine("**************************************************");

                Console.WriteLine("Entre com a opção desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {

                    case 1:

                        Console.WriteLine("Adicione Cliente:");

                        fila.Enqueue(Console.ReadLine());

                        Console.WriteLine("Cliente Adicionado!\n");

                        break;
                    case 2:
                        foreach (var nomes in fila)
                        {
                            Console.WriteLine(nomes);
                        }
                        break;
                    case 3:

                        if (fila.Count > 0)
                        {
                            fila.Dequeue();

                            Console.WriteLine("O Cliente foi Chamado!\n");
                            foreach (var nomes in fila)
                            {
                                Console.WriteLine(nomes);
                            }
                        }
                        else
                        {
                            Console.WriteLine("A Fila está vazia!\n");
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
