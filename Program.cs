using System;

namespace Number_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int evenNumber;
            int oddNumber;

            while (true)
            {
                Console.WriteLine("Welcome to your random number generator" +
                   "          \nPlease select either number 1,2 or 3" +
                   "          \n1. Even number: " +
                   "          \n2. Odd number:" +
                   "          \n3. Exit: ");

                string userChoice = Console.ReadLine();

                if(userChoice == "1")
                {
                    // Creates even number 
                    evenNumber = rnd.Next(int.MaxValue / 2) * 2;
                    Console.WriteLine(evenNumber);
                }

                else if(userChoice == "2")
                {
                    // Creates odd number
                    oddNumber = rnd.Next(int.MaxValue / 2) * 2 + 1;
                    Console.WriteLine(oddNumber);
                }

                else
                {
                    break;
                }

            }
        }
    }
}
