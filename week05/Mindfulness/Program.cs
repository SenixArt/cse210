using System;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS: Para ganar el 7% extra, puedes declarar aquí 
        // una variable que cuente cuántas actividades se han completado en total
        // y mostrarlo al salir del programa.
        
        string choice = "";

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
                // Aquí instanciarás BreathingActivity y llamarás a su método Run()
                // BreathingActivity activity = new BreathingActivity();
                // activity.Run();
            }
            else if (choice == "2")
            {
                // Aquí instanciarás ReflectionActivity
            }
            else if (choice == "3")
            {
                // Aquí instanciarás ListingActivity
            }
        }
    }
}
