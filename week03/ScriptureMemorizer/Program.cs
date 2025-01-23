using System;

class Program
{
    static void Main(string[] args)
    {
        var scripture = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart and lean not on your own understanding.");
        
        DisplayScripture(scripture);

        while (true)
        {
            Console.WriteLine("Press Enter to hide some words or type 'quit' to end.");
            var input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            
            scripture.HideRandomWord();
            Console.Clear();
            DisplayScripture(scripture);

            if (scripture.Words.All(w => w.IsHidden))
            {
                Console.WriteLine("All words have been hidden. Ending the program.");
                break;
            }
        }
    }

    private static void DisplayScripture(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine($"{scripture.Reference.Reference}: {scripture.GetScriptureText()}");
    }
    
}