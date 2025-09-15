using System;

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
                Console.WriteLine("You are too young to play!!!!");
            }
            int playerCount, dealerCount, currentCard;
            int[] deck = new int[52];
            for (int i = 0; i < deck.Length; i++)
            {
                switch (i)
                {
                    case int i when (i >= 0 && i <= 3):
                        deck[i] = 1;
                        break;
                    case int i when (i >= 4 && i <= 7):
                        deck[i] = 2;
                        break;
                    case int i when (i >= 8 && i <= 11):
                        deck[i] = 3;
                        break;
                    case int i when (i >= 12 && i <= 15):
                        deck[i] = 4;
                        break;
                    case int i when (i >= 16 && i <= 19):
                        deck[i] = 5;
                        break;
                    case int i when (i >= 20 && i <= 23):
                        deck[i] = 6;
                        break;
                    case int i when (i >= 24 && i <= 27):
                        deck[i] = 7;
                        break;
                    case int i when (i >= 28 && i <= 31):
                        deck[i] = 8;
                        break;
                    case int i when (i >= 32 && i <= 35):
                        deck[i] = 9;
                        break;
                    case int i when (i >= 36 && i <= 52):
                        deck[i] = 10;
                        break;
                }


                //test code for shuffle
                int[] arr = new int[52];
                for (int i = 0; i < arr.Length; i++)
                {
                    int[i] = i;
                }
                suffle(arr);
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }


        public static int[] shuffle(int[] arr){
            Random r = new Random();
            //will probably override values
            for (int i = 0; i < arr.Length; i++)
            {
                r(52);
                arr[i] = r.Next();
            }
            return arr[];

        }
    }
}
