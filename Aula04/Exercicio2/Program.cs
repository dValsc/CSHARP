using System.Reflection;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string continua = "S";
            int genero, total =0, somaidade = 0;
            int desenvolvedor, Backend1 = 0, Frontend2 = 0, Mobile3 = 0, FullStack4 = 0;

            while (continua.Equals("S"))
            {

                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                Console.Write("\nGENERO\n1 - MulherCis\n2 - Homem Cis\n3 - Não Binário\n4 - Mulher Trans\n5 - Homem Trans\n6 - Outros\nDigite sua identidade de genero: ");
                genero = int.Parse(Console.ReadLine());

                Console.Write("\nDESENVOLVEDOR\n1 - Backend\n2 - Frontend\n3 - Mobile\n4 - FullStack\nPessoa desenvolvedora: ");
                desenvolvedor = int.Parse(Console.ReadLine());

                if (desenvolvedor == 1)
                {
                    Backend1 += 1;
                }
                if ((genero == 1 || genero == 4) && desenvolvedor ==2)
                {
                    Frontend2 += 1;
                }
                if ((genero == 3 || genero == 5) && desenvolvedor == 3 && idade > 40) 
                {
                    Mobile3 += 1;
                }
                if (genero == 3 && desenvolvedor == 4 && idade < 30) 
                {
                    FullStack4 += 1;
                }
                total = total + 1;
                somaidade = somaidade + idade;

                Console.Write("Deseja continuar? (S/N): ");
                continua = Console.ReadLine().ToUpper();

            } while (continua.Equals("S")) ;

            Console.WriteLine($"Número de pessoas desenvolvedoras Backend: {Backend1}.");
            Console.WriteLine($"Número de Mulheres Cis e Trans desenvolvedoras Frontend: {Frontend2}.");
            Console.WriteLine($"Número de Homens Cis e Trans desenvolvedores Mobile maiores de 40 anos: {Mobile3}.");
            Console.WriteLine($"NO número de Não Binários desenvolvedores FullStack menores de 30 anos: {FullStack4}.");
            Console.WriteLine($"O número total de pessoas que responderam à pesquisa: {total}.");
            Console.WriteLine($"A média de idade das pessoas que responderam à pesquisa: {somaidade/total}.");







        } 
       




        }
    }
