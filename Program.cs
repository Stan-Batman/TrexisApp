// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
        // Prompt the user for their name
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        // Prompt the user for their age and validate the input
        int age;
        while (true)
        {
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            if (int.TryParse(ageInput, out age) && age > 0)
            {
                break; // Exit the loop if the input is a valid positive integer
            }
            else
            
            {
                Console.WriteLine("Please enter a valid positive integer for age.");
            }
        }

        // Display the greeting message
        Console.WriteLine($"Hello, {name}! You are {age} years old.");
    }
}
