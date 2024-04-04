using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Please enter a number:");
            string userInput = Console.ReadLine();

            // Convertir la entrada del usuario a un número entero
            if (int.TryParse(userInput, out int number))
            {
                Console.WriteLine($"You entered: {number}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }


        }

    }

}
