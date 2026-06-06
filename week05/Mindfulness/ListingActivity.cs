using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    private Random _random = new Random();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        // Initialize prompts
        _prompts = new List<string>
        {
            "When have you felt the Holy Ghost this month:",
            "What are some things that make you happy:",
            "List personal strengths you have:",
            "List places you have enjoyed visiting:",
            "What goals you are working on:"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"*** {prompt} ***");

        Console.WriteLine("\nYou may begin in:");
        ShowCountDown(5);

        List<string> items = GetListFromUser();

        _count = items.Count;

        Console.WriteLine($"\nYou listed {_count} items!");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();

        Console.WriteLine("\nStart listing items (press Enter after each):");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
            }
        }

        return responses;
    }
}