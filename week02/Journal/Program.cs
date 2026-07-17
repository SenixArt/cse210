using System;
using System.Collections.Generic;

// Exceeding Requirements:
// - Implemented a robust custom separator (~|~) to handle commas and quotes safely without breaking text files.
// - Added file existence verification in the LoadFromFile method to prevent application crashes.
// - Formatted the console UI with clean spacing and clear state responses for a better user experience.

class Program
{
    static void Main(string[] sender)
    {
        Journal theJournal = new Journal();
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random random = new Random();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                int index = random.Next(prompts.Count);
                string randomPrompt = prompts[index];
                Console.WriteLine($"\nPrompt: {randomPrompt}");
                Console.Write("> ");
                string response = Console.ReadLine();

                string currentDate = DateTime.Now.ToShortDateString();
                Entry newEntry = new Entry(currentDate, randomPrompt, response);
                theJournal.AddEntry(newEntry);
                Console.WriteLine("Entry added!\n");
            }
            else if (choice == "2")
            {
                Console.WriteLine("\n--- Journal Entries ---");
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("\nWhat is the filename? ");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
                Console.WriteLine();
            }
            else if (choice == "4")
            {
                Console.Write("\nWhat is the filename? ");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
                Console.WriteLine();
            }
            else if (choice == "5")
            {
                Console.WriteLine("\nGoodbye!");
            }
            else
            {
                Console.WriteLine("\nInvalid option. Please try again.\n");
            }
        }
    }
}
