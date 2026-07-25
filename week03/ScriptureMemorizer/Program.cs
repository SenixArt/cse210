using System;
using System.Collections.Generic;

// EXCEEDING REQUIREMENTS:
// 1. The program selects a random scripture from a library/list of scriptures instead of just one.
// 2. The HideRandomWords method in the Scripture class has been improved to only select and hide words that are not already hidden, preventing the program from wasting cycles trying to hide already invisible words.

class Program
{
    static void Main(string[] args)
    {
        // 1. Crear una biblioteca de escrituras (Exceeding requirements)
        List<Scripture> scriptureLibrary = new List<Scripture>();
        
        scriptureLibrary.Add(new Scripture(
            new Reference("John", 3, 16), 
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
            
        scriptureLibrary.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6), 
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."));

        scriptureLibrary.Add(new Scripture(
            new Reference("Philippians", 4, 13), 
            "I can do all this through him who gives me strength."));

        // Seleccionar una al azar
        Random rand = new Random();
        int index = rand.Next(scriptureLibrary.Count);
        Scripture selectedScripture = scriptureLibrary[index];

        string userInput = "";

        // Bucle principal
        while (userInput != "quit" && !selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            
            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                // Oculta 3 palabras en cada turno (puedes cambiar este número)
                selectedScripture.HideRandomWords(3);
            }
        }

        // Mostrar la pantalla final si todo se ocultó y el usuario no escribió quit
        if (selectedScripture.IsCompletelyHidden() && userInput != "quit")
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
        }
    }
}
