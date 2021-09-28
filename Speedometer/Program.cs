using System;

namespace Speedometer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Sisesta läbitud vahemaa kilomeetrites: ");
            int speed = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta kulunud aeg tundides: ");
            int time = Int32.Parse(Console.ReadLine());

            int kph = speed / time;
            Console.WriteLine($"Sõiduki kiirus on: {kph}");


        }
    }
}
