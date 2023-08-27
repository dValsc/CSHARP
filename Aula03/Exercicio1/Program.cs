namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            float numero, nA, nB, nC;

             Console.WriteLine("Digite o número A: ");
            nA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número B: ");
            nB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número C: ");
            nC = Convert.ToInt32(Console.ReadLine());

            numero = nA + nB;

            if (numero > nC)
            {
                Console.WriteLine($"A soma de {nA} + {nB} é Maior que {nC}");
            }
            else if (numero < nC)
            {
                Console.WriteLine($"A soma de {nA} + {nB} é Menor que {nC}");
            }

            else if (numero == nC)
                    {
                Console.WriteLine($"A soma de {nA} + {nB} é Igual que {nC}");
            }
            
        }
    }
}