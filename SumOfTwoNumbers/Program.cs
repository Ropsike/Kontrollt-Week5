using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Sisesta oma esimene number: ");

            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta oma teine number: ");

            int num2 = Int32.Parse(Console.ReadLine());

            int result = num1 + num2;

            Console.WriteLine($"{num1} + {num2} = {result}");

        }
    }
}
