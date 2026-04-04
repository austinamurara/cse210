using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity() : base("Listing Activity", 
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
        }

        public void Run()
        {
            DisplayStartingMessage();

            // 1. Pick a random prompt
            Random random = new Random();
            string prompt = _prompts[random.Next(_prompts.Count)];

            Console.WriteLine("\nList as many responses as you can to the following prompt:");
            Console.WriteLine($" --- {prompt} --- ");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.WriteLine();

            // 2. Start the listing loop
            List<string> userItems = new List<string>();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    userItems.Add(input);
                }
            }

            // 3. Show the result
            Console.WriteLine($"You listed {userItems.Count} items!");

            DisplayEndingMessage();
        }
    }
}