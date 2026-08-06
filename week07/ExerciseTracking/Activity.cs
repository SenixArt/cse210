using System;

public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    // Métodos abstractos que cada deporte calculará a su manera
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Método general que arma el texto final usando polimorfismo
    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min): Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
