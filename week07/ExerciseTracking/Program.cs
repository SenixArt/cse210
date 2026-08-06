using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Crear las actividades
        Running runningActivity = new Running("03 Nov 2022", 30, 4.8);
        Cycling cyclingActivity = new Cycling("04 Nov 2022", 45, 20.5);
        Swimming swimmingActivity = new Swimming("05 Nov 2022", 25, 40);

        // Guardarlas en una lista de la clase base (Polimorfismo)
        List<Activity> activities = new List<Activity>();
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        // Imprimir el resumen de cada una
        Console.WriteLine("Exercise Tracking Program:\n");
        foreach (Activity act in activities)
        {
            Console.WriteLine(act.GetSummary());
        }
    }
}
