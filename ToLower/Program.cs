using System;

namespace ToLower
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Sisesta üks sõna: ");
            string userInput = Console.ReadLine().ToLower();
            Console.WriteLine(userInput);
        }
    }
}