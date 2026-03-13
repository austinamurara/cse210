using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");

        // 1. Create a dummy entry to test
        Entry testEntry = new Entry();
        testEntry._date = "2026-03-13";
        testEntry._promptText = "What was the best part of your day?";
        testEntry._entryText = "I finally fixed my C# compiler error!";

        // 2. Use Abstraction to add and save
        theJournal.AddEntry(testEntry);
        
        Console.WriteLine("Saving to file...");
        theJournal.SaveToFile("myJournal.txt");

        Console.WriteLine("Goodbye!");
    }
}