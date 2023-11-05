using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers. You can type 0 to finish the list.");

        int participantNumber = -1;
        while (participantNumber != 0)
        {
            Console.Write("Enter a number: ");
            
            string Response = Console.ReadLine();
            participantNumber = int.Parse(Response);
            
            if (participantNumber != 0)
            {
                numbers.Add(participantNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}