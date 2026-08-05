using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        Random random = new Random();

        Console.WriteLine("List as many responses you can to the following prompt:");
        
        int promptIndex = random.Next(_prompts.Count);
        Console.WriteLine($" --- {_prompts[promptIndex]} --- ");
        
        Console.Write("You may begin in: ");
        ShowCountDown(5); // Cuenta regresiva antes de empezar
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        
        int count = 0;

        // Ciclo para escribir hasta que el tiempo se acabe
        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine(); 
            count++;
        }

        Console.WriteLine($"You listed {count} items!");
        Console.WriteLine();

        DisplayEndingMessage();
    }
}
