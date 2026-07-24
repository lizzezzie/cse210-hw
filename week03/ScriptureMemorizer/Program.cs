using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creativity:
        // This program stores multiple scriptures and randomly selects one
        // each time it runs. It also hides a random number of words (between
        // 2 and 4) each time the user presses Enter.

        List<(Reference, string)> scriptures = new List<(Reference, string)>
        {
            (
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
            ),
            (
                new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
            ),
            (
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me."
            ),
            (
                new Reference("Mosiah", 2, 17),
                "When ye are in the service of your fellow beings ye are only in the service of your God."
            )
        };

        Random random = new Random();

        var selected = scriptures[random.Next(scriptures.Count)];

        Scripture scripture = new Scripture(selected.Item1, selected.Item2);

        string input = "";

        while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.Write("Press Enter to hide words or type 'quit' to exit: ");

            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                int wordsToHide = random.Next(2, 5);
                scripture.HideRandomWords(wordsToHide);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Program ended. Great job memorizing the scripture!");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}