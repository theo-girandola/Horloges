using System;
using System.Timers;

public class Example
{
    private static System.Timers.Timer aTimer;

    public static void Main()
    {
        SetTimer();

        
        Console.ReadLine();
        aTimer.Stop();
        aTimer.Dispose();

        Console.WriteLine("Terminating the application...");
    }

    private static void SetTimer()
    {
        
        aTimer = new System.Timers.Timer(1000);
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        Console.WriteLine("{0:HH:mm:ss}",
                          e.SignalTime);
    }
}
