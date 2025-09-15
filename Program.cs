using System;

namespace studioTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello, World!");
            
            //test code for shuffle
            int[] arr = new int[52];
            for (int i = 0; i < arr.Length; i++)
            {
                int[i] = i;
            }
            suffle(arr);
            for (int i = 0;i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        public static int[] shuffle(int[] arr) {
            Random r = new Random();
            //will probably override values
            for(int i = 0; i < arr.Length; i++)
            {
                r(52);
                arr[i] = r.Next();
            }
            return arr[];
        }
    }
}
