namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cores= new List<string>();
            string cor;
           
            for (int i = 0; i < 5; i ++)
            {
                Console.WriteLine("Digite uma cor: ");
                cor = Console.ReadLine();
                cores.Add(cor);
            }
         

            foreach (string cor1 in cores)
            {
                Console.WriteLine(cor1);
            }

           cores.Sort();

            foreach (string cor1 in cores)
            {
                Console.WriteLine(cor1);
            }

        }
    }
}