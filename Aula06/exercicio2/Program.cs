namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> setNum = new HashSet<int>();
            int num;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite uma numero: ");
                num = Convert.ToInt32(Console.ReadLine());
                setNum.Add(num);
            }

            foreach (int nums in setNum)
            {
                Console.WriteLine(nums);
            }
        }
    }
}