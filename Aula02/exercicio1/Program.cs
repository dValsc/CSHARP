namespace exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario, abono, novosalario;
             
            Console.WriteLine("Digite o valor do salário:");
            salario = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o valor do abono:");
            abono = Convert.ToSingle(Console.ReadLine());

            novosalario = salario + abono;


            Console.WriteLine("O valor do novo salário é: "+ novosalario);
            
        }
    }
}