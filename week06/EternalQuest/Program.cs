using System;

// EXCEEDING REQUIREMENTS:
// To show creativity and exceed the core requirements, I added a "Leveling/Rank System" 
// inside the GoalManager.DisplayPlayerInfo() method. Every time the user accumulates 
// 1000 points, their Rank Level increases dynamically (e.g., Level 1, Level 2...), 
// giving them a sense of progression beyond just raw points.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
