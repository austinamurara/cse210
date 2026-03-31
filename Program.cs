using System;

class Program
{
    static void Main()
    {
        // This is for Austina's project
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        string input = "";
        while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            input = Console.ReadLine() ?? "";

            if (input.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}