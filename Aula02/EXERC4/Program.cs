namespace EXERC4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? palavra1, palavra2, palavra3;
            
            Console.WriteLine("Digite a primeira palavra: ");
            palavra1 = Console.ReadLine();

            Console.WriteLine("Digite a segunda palavra: ");
            palavra2 = Console.ReadLine();

            Console.WriteLine("Digite a terceira palavra: ");
            palavra3 = Console.ReadLine();

            if (palavra1 is not null && palavra2 is not null && palavra3 is not null)
            {
                // verificando se é vertebrado ou invertebrado
                if (palavra1.Equals("vertebrado"))
                {
                    //verificando se é ave ou mamífero
                    if (palavra2.Equals("ave"))
                    {

                    }
                    else
                    { 
                    
                    }
                    //verificando se é carnivoro ou oniforo
                    if (palavra3.Equals("carnivoro"))
                    {
                        Console.WriteLine("Águia");
                    }
                    else
                    {
                        Console.WriteLine("Pomba");
                    }
                }
                else
                { 
                
                }
                if (palavra1.Equals("vertebrado"))
                {
                    //verificando se é ave ou mamífero
                    if (palavra2.Equals("ave"))
                    {

                    }
                    else
                    {

                    }
                    //verificando se é carnivoro ou oniforo
                    if (palavra3.Equals("carnivoro"))
                    {
                        Console.WriteLine("Águia");
                    }
                    else
                    {
                        Console.WriteLine("Pomba");
                    }
                }
                else
                {

                }
                if (palavra1.Equals("vertebrado"))
                {
                    //verificando se é ave ou mamífero
                    if (palavra2.Equals("ave"))
                    {

                    }
                    else
                    {

                    }
                    //verificando se é carnivoro ou oniforo
                    if (palavra3.Equals("carnivoro"))
                    {
                        Console.WriteLine("Águia");
                    }
                    else
                    {
                        Console.WriteLine("Pomba");
                    }
                }
                else
                {

                }
            }
            else
            {
                Console.WriteLine("As palavras não podem ser nulas");           
            }
        }
    }
}