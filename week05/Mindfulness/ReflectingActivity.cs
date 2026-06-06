using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    private Random _random = new Random();

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognise the power you have and how you can use it in other aspects of your life.";

        // Initialize prompts
        _prompts = new List<string>
        {
            "Think of a time you overcame a challenge.",
            "Think of a time you helped someone in need.",
            "Think of a time you achieved something very difficult.",
            "Think of a time you did something you thought you couldn't do."
        };

        // Initialize questions
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "What did you learn about yourself?",
            "How did you feel at the time?",
            "What strengths did you use?",
            "What could you improve next time?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayPrompt();
        DisplayQuestions();

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        return _questions[_random.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();

        Console.WriteLine("\nConsider the following prompt: ");
        Console.WriteLine(prompt);

        Console.WriteLine("\nWhen you have something in mind, press Enter to continue...");
        Console.ReadLine();

        Console.WriteLine("\nNow reflect on the following questions:");
        Console.WriteLine("Take your time...");
        ShowSpinner(3);
    }

    public void DisplayQuestions()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"\n{GetRandomQuestion()}");
            ShowSpinner(5);
        }
    }
}