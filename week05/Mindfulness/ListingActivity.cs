using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity",
        "This activity helps you list as many positive things as you can in a certain area.") { }

    public override void Run()
    {
        Start();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.WriteLine("You will have a few seconds to think before you start listing...");

        ShowCountdown(5);

        List<string> userResponses = new List<string>();
        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.Write("Enter an item: ");
            userResponses.Add(Console.ReadLine());
            elapsedTime += 3; // Approximate time per response
        }

        Console.WriteLine($"\nYou listed {userResponses.Count} items.");
        End();
    }
}
