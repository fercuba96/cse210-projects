using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {  
        
   // A >= 90;
    //B >= 80;
    //C >= 70;
    //D >= 60;
    //F < 60;

        Console.Write("What is your grade? ");
        string x = Console.ReadLine();
        int number = int.Parse(x);
        string letter = "";
        if (number >=90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
         }
        else
{
    letter = "F";
}
    
Console.WriteLine($"Your grade is {letter}.");



if (number >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You can do it better next time!");
        }    
    }


}