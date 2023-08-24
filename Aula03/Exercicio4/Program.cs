namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String? nome, cargonome = "";
            int cargo;
            float salario, reajuste;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("1 - Gerente");
            Console.WriteLine("2 - Vendedor");
            Console.WriteLine("3 - Supervisor");
            Console.WriteLine("4 - Motorista");
            Console.WriteLine("5 - Estoquista");
            Console.WriteLine("6 - Técnico de TI");



            Console.WriteLine("Digite o seu cargo: ");
            cargo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o seu salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    reajuste = (salario * 10) / 100;
                    cargonome = "Gerente";
                    break;
                case 2:
                    reajuste = (salario * 7) / 100;
                    cargonome = "Vendedor";
                    break;
                case 3:
                    reajuste = (salario * 9) / 100;
                    cargonome = "Supervisor";
                    break;
                case 4:
                    reajuste = (salario * 6) / 100;
                    cargonome = "Motorista";
                    break;
                case 5:
                    reajuste = (salario * 5) / 100;
                    cargonome = "Estoquista";
                    break;
                default:
                    reajuste = (salario * 8) / 100;
                    cargonome = "Técnico de TI";
                    break;
            }
            Console.WriteLine($"O reajuste do Salário do(a) {nome} é de: {reajuste}");
            Console.WriteLine($"O novo Salário do(a) {nome},{cargonome}, é de: {salario + reajuste}");
        }
    }
}