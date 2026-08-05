using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Método para mostrar el mensaje inicial y pedir el tiempo
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        
        // Guardamos la duración ingresada por el usuario
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    // Método para mostrar el mensaje final
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    // Animación de carga (Spinner) usando los caracteres de backspace (\b)
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < futureTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250); // Pausa de un cuarto de segundo
            Console.Write("\b \b");

            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    // Animación de cuenta regresiva
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // Pausa de 1 segundo
            Console.Write("\b \b");
        }
    }

    // Getter para que las clases hijas puedan usar la duración en sus bucles
    public int GetDuration()
    {
        return _duration;
    }
}
