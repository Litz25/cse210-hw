using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
    }

    public void DisplayStartingMessage()
    {
        // Display activity name
        Console.WriteLine($"\n--- {_name} ---");

        // Display description
        Console.WriteLine(_description);

        // Ask user for duration
        Console.Write("\nHow long, in seconds, would you like this activity? ");
        _duration = int.Parse(Console.ReadLine());

        // Show spinner
        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        // Congratulate user
        Console.WriteLine("\nWell done!");

        // Show duration completed
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");

        // Show spinner
        ShowSpinner(3);
        Console.WriteLine("\nActivity complete. Take a moment to relax.");
    }

    public void ShowSpinner(int seconds)
    {
        // Spinner animation
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
            i++;
        }
    }

    public void ShowCountDown(int seconds)
    {
        // Countdown animation
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}