public class Entry

{
    //Member variables
    public string _date;
    public string _promptText;
    public string _entryText;

    //Method to display the entry details
    public void Display()
    {
        //Display the date, prompt text, and entry text
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine($"Date: {_date} | Prompt: {_promptText} | Entry: {_entryText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine("---------------------------------------------");

        Console.WriteLine(); // Add an empty line for better readability
    }
}

