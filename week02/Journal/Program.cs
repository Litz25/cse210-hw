using System;

class Program
{static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n****JOURNAL MENU****");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.Write("Select option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = generator.GetRandomPrompt();

                Console.WriteLine(entry._promptText);
                Console.Write("Your response: ");
                entry._entryText = Console.ReadLine();

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.Display();
            }
            else if (choice == "3")
            {
                Console.Write("File name: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            else if (choice == "4")
            {
                Console.Write("File name: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (choice == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}