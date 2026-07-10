using System;

class Program
{
    // The main entry point for the application
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int number = PromptUserNumber();

        int squaredNumber = SquareNumber(number);

        int cubedNumber = CubedNumber(number);

        DisplayResult(name, squaredNumber, cubedNumber);
    }

    // Display a welcome message to the user
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Prompt the user for their name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Prompt the user for their favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        return number;
    }

    // Calculate the square of the number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Calculate the cube of the number
    static int CubedNumber(int number)
    {
        return number * number * number;
    }

    // Display the result to the user
    static void DisplayResult(string name, int squaredNumber, int cubedNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
        Console.WriteLine($"{name}, the cube of your number is {cubedNumber}.");
    }

}