using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Sisesta oma number:");

            int userNumber = Int32.Parse(Console.ReadLine());
            if (userNumber < 0)
            {
                Console.WriteLine("Number on negatiivne.");
            }
            else if (userNumber == 0)
            {
                Console.WriteLine("Number on 0");
            }
            else if (userNumber > 0)
            {
                Console.WriteLine("Number on positiivne.");
            }
            else
            {
                Console.WriteLine("Ma ei saa aru mis see on");
            }

        }
    }
}
