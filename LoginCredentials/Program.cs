using System;

namespace LoginCredentials
{
    class Program
    {
        static void Main(string[] args)
        {
  

            Console.WriteLine("Login: ");
            string Login = Console.ReadLine();
            Console.WriteLine("Password: ");
            string Password = Console.ReadLine();

            if ((Login == "admin") && (Password == "pass1234"))
            {
                Console.WriteLine("Kasutaja on õige, tere tulemast!");
            }
            else if ((Login == "admin") && (Password != "pass1234"))
            {
                Console.WriteLine("Parool on õige!");
            }
            else if ((Login != "admin") && (Password == "pass1234"))
            {
                Console.WriteLine("Kasutajanimi on vale!");
            }
            else
            {
                Console.WriteLine("Kasutaja nimi või parool on vale!");
            }
        }
    }
}