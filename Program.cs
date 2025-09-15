using System;

namespace studioTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            }
        }
    }
}
