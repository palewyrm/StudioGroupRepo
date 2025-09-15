namespace studioTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Studio 1 BlackJack!");

            Console.WriteLine("Are you over 18 years old? type y or n");
            char ageInput = Convert.ToChar(Console.ReadLine());

            if (ageInput == 'y')
            {
                Console.WriteLine("");


            }
            else 
            {
                Console.WriteLine("You are to young to play!!!!");
            }

        }

        

    }
}
