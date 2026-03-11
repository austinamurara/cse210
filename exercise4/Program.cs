using System;
using System.Collections.Generic; // This line is required for Lists!

List<int> numbers = new List<int>();

Console.WriteLine("Enter a list of numbers, type 0 when finished.");

int userNumber = -1;

// Step 1: Collect the numbers
while (userNumber != 0)
{
    Console.Write("Enter number: ");
    userNumber = int.Parse(Console.ReadLine());
    
    // Don't add 0 to the list
    if (userNumber != 0)
    {
        numbers.Add(userNumber);
    }
}

// Step 2: Math (Sum, Average, Max)
int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}

float average = ((float)sum) / numbers.Count;

int max = numbers[0];
foreach (int number in numbers)
{
    if (number > max)
    {
        max = number;
    }
}

// Step 3: Output results
Console.WriteLine($"The sum is: {sum}");
Console.WriteLine($"The average is: {average}");
Console.WriteLine($"The largest number is: {max}");