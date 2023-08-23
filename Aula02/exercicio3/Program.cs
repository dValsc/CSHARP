namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float SalarioBruto, AdicionalNoturno, HorasExtras, Descontos, SalarioLiquido;

            Console.WriteLine("Digite o Salário Bruto:");
            SalarioBruto = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o Adicional Noturno:");
            AdicionalNoturno = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite as Horas Extras:");
            HorasExtras = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite os Descontos:");
            Descontos = Convert.ToSingle(Console.ReadLine());

            SalarioLiquido = SalarioBruto + AdicionalNoturno + (HorasExtras*5) - Descontos;


            Console.WriteLine("Salário Líquido: " + SalarioLiquido);
        }
    }
}