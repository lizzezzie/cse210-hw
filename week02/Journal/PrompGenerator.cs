using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Member variable to hold the list of prompts.
    private List<string> _prompts;

    // Constructor to initialize the list of prompts
    public PromptGenerator()
    {
        // Initialize the list of prompts with predefined questions
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If there was something I could do over today, what would it be?"
        };
    }

    // Method to get a random prompt from the list.
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
