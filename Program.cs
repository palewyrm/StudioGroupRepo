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
            int playerCount, dealerCount, currentCard;

            if (ageInput == 'y')
            {
                Console.WriteLine("Let's play BlackJack!");


                int[] deck = new int[52];
                for (int i = 0; i < deck.Length; i++)
                {
                    switch (i)
                    {
                        case int n when (n >= 0 && n <= 3):
                            deck[i] = 1;
                            break;
                        case int n when (n >= 4 && n <= 7):
                            deck[i] = 2;
                            break;
                        case int n when (n >= 8 && n <= 11):
                            deck[i] = 3;
                            break;
                        case int n when (n >= 12 && n <= 15):
                            deck[i] = 4;
                            break;
                        case int n when (n >= 16 && n <= 19):
                            deck[i] = 5;
                            break;
                        case int n when (n >= 20 && n <= 23):
                            deck[i] = 6;
                            break;
                        case int n when (n >= 24 && n <= 27):
                            deck[i] = 7;
                            break;
                        case int n when (n >= 28 && n <= 31):
                            deck[i] = 8;
                            break;
                        case int n when (n >= 32 && n <= 35):
                            deck[i] = 9;
                            break;
                        case int n when (n >= 36 && n <= 51):
                            deck[i] = 10;
                            break;
                    }
                }

                //test code for shuffle
                int[] arr = new int[52];
                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] = j;
                }
                shuffle(arr);
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.WriteLine(arr[j]);
                }
            }
            else
            {
                Console.WriteLine("You are too young to play!!!!");
            }

            Console.ReadLine();
        }

        public static int[] shuffle(int[] arr)
        {
            Random r = new Random();
            // Fisher-Yates shuffle algorithm
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int randomIndex = r.Next(i + 1);
                int temp = arr[i];
                arr[i] = arr[randomIndex];
                arr[randomIndex] = temp;
            }
            return arr;
        }
    }
}
