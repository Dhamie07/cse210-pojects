using System;
using System.Collections.Generic;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by guiding your breathing.") { }

    public override void Run()
    {
        Start();

        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountdown(4);

            Console.WriteLine("Breathe out...");
            ShowCountdown(4);

            elapsedTime += 8; // Each cycle takes 8 seconds
        }

        End();
    }
}