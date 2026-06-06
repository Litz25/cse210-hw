using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;

        while (elapsed < _duration)
        {
            // Breathe in
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            elapsed += 4;

            // Breathe out
            Console.Write("\nBreathe out...");
            ShowCountDown(4);
            elapsed += 4;

            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}