using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Timers;


public class Timer
{
    public delegate void Action();
    public event Action OnTimeElapsed;
    public void Start(int seconds)
    {
        Thread timerThread = new Thread(() => {
           
            Thread.Sleep(seconds * 1000);

            
            OnTimeElapsed?.Invoke();
        });

        
        timerThread.Start();
    }
}
class Program
{
    static void Main(string[] args)
    {
        
        Timer timer = new Timer();
        
        timer.OnTimeElapsed += () =>
        {
            Console.WriteLine("Time is up!");
        };


        Console.WriteLine("Timer started for 5 seconds...");
        timer.Start(5);
    }
}

