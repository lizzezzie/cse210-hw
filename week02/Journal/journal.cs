using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    //A list that holds all individual objects of the Entry class
    public List<Entry> _entries = new List<Entry>();

    //Method to add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    
    //Method to loop through all entries and display their details
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }
        foreach (Entry entry in _entries)
        {
            //Call the Display method of the Entry class to show the details of each entry
            entry.Display();
        }
    }

    //Method to save all entries to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                // Write the entry details to the file in a structured format
                outputFile.WriteLine($"{entry._date}| {entry._promptText}| {entry._entryText}| ");
                
                outputFile.WriteLine(); // Add an empty line for better readability
            }
        }
    }

    //Method to load entries from a file
    public void loadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine($"File '{file}' not found.");
            return;
        }

        // Clear existing entries before loading new ones
        _entries.Clear();

        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            //split the line into 3 original pieces
            string[] parts = line.Split('|');

            if (parts.Length == 3)
            {
                Entry loadEntry = new Entry();
                loadEntry._date = parts[0]; // Extract date
                loadEntry._promptText = parts[1]; // Extract prompt text
                loadEntry._entryText = parts[2]; // Extract entry text

                _entries.Add(loadEntry);
            }
        }
        Console.WriteLine("Journal loaded successfully."); 

    }
}