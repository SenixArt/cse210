using System;

public class BreathingActivity : Activity
{
    // El constructor llama al constructor de la clase base (Activity)
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        // 1. Mostrar el mensaje inicial (Heredado de Activity)
        DisplayStartingMessage();

        // 2. Obtener el tiempo que el usuario escribió
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        // 3. Ciclo de respiración hasta que se acabe el tiempo
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(4); // Cuenta regresiva de 4 segundos para inhalar
            
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(6); // Cuenta regresiva de 6 segundos para exhalar
            Console.WriteLine();
        }

        // 4. Mostrar el mensaje final (Heredado de Activity)
        DisplayEndingMessage();
    }
}
