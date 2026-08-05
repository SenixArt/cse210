using System;

// EXCEEDING REQUIREMENTS:
// Added a counter variable (_totalActivities) to track the total number of 
// mindfulness activities performed during the session and display a summary 
// message before the program exits.

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        int totalActivities = 0;

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                totalActivities++;
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
                totalActivities++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                totalActivities++;
            }
        }

        Console.Clear();
        Console.WriteLine($"Great job! You completed a total of {totalActivities} mindfulness activities this session.");
        Console.WriteLine("Goodbye!");
    }
}
