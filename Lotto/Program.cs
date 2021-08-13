
using System;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] lottotal = new int[7];
            int[] usernumbers = new int[7];

            Random random = new Random();
            Console.WriteLine("Choose 7 numbers between 1-20");

            for (int i = 0; i < lottotal.Length; i++)
            {
                while(true)
                {
                    int tal = random.Next(1, 21);
                    if (Array.IndexOf(lottotal, tal) == -1)
                    {
                        lottotal[i] = tal;
                        break;
                    }
                }
                while (true)
                {
                    int tal = Convert.ToInt32(Console.ReadLine());
                    if (Array.IndexOf(usernumbers, tal) == -1)
                    {
                        usernumbers[i] = tal;
                        break;
                    }
                }
            }

            Array.Sort(lottotal);
            Array.Sort(usernumbers);

            int count = 0;

            for (int i = 0; i < usernumbers.Length; i++)
            {
                for (int j = 0; j < lottotal.Length; j++)
                {
                    if (usernumbers[i] == lottotal[j])
                    {
                        count++;
                    }
                }
            }


            Console.Write("Udtrukne lottotal: ");
            for (int i = 0; i < lottotal.Length; i++)
            {
                Console.Write(lottotal[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Brugerens lottotal: ");
            for (int i = 0; i < usernumbers.Length; i++)
            {
                Console.Write(usernumbers[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Rigtige: " + count);

            if (count == 2)
            {
                Console.WriteLine("Congrats on winning 100$");
            }
            else if (count == 3)
            {
                Console.WriteLine("Congrats on winning 500$");
            }
            else if (count == 4)
            {
                Console.WriteLine("Congrats on winning 1000$");
            }
            else if (count == 5)
            {
                Console.WriteLine("Congrats on winning 2500$");
            }
            else if (count == 6)
            {
                Console.WriteLine("Congrats on winning 5000$");
            }
            else if (count == 7)
            {
                Console.WriteLine("Congrats on winning our grand price on 10000$");
            }
            else
            {
                Console.WriteLine("Sorry you didn't win anything.");
            }
            Console.ReadKey();
        }
    }
}
