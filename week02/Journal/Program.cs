using System;

class Program
{
    static void Main(string[] args)
    {
        // CREATIVITY
        // Added a check to make sure the user doesn't load 
        // a file that doesn't exist, preventing a crash,
        // and formatted layouts safely using '|'.
        
        // Instantiate helper objects
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string userChoice = "";

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("You can write journal entries, display them, load from a file, or save to a file.");

        // The Main Loop
        while (userChoice != "5")
        {
            // Display menu options
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            // Get user input
            userChoice = Console.ReadLine();

            // Handle user input
            if (userChoice == "1")
            {
                // Generate a random prompt
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\n{prompt}");
                Console.Write("Enter your response: ");
                string response = Console.ReadLine();

                // Get the current date outomatically as a string
                string dateText = DateTime.Now.ToString("MM/dd/yyyy");

                // Create a new entry and populate its variables
                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                // Add the new entry to the journal
                theJournal.AddEntry(newEntry);

            }
            else if (userChoice == "2")
            {
                Console.WriteLine("\n-----Journal Entries-----");

                theJournal.DisplayAll();
            }

            else if (userChoice == "3")
            {
                Console.Write("Please enter the filename to load your journal entries from: ");
                string filename = Console.ReadLine();
                // Check if the file exists before attempting to load
                theJournal.loadFromFile(filename);
            }

            else if (userChoice == "4")
            {
                Console.Write("Please enter the filename to save your journal entries: ");
                string filename = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(filename))
                {
                    Console.WriteLine("Filename cannot be empty. Please enter a valid filename.");
                    Console.Write("Please enter the filename to save your journal entries: ");
                    filename = Console.ReadLine();
                }
                // Save the journal entries to the specified file
                theJournal.SaveToFile(filename);
            }
            else if (userChoice == "5")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}

