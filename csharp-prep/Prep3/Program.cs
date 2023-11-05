using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random(); 
        int magicNum = randomGenerator.Next(1, 101);

        int numberguess = -1;

        while (numberguess != magicNum)

        {
            Console.Write("What is your guess? ");
            numberguess = int.Parse(Console.ReadLine());

            if (magicNum > numberguess)

            {Console.WriteLine ("Higher");}

            else if (magicNum < numberguess)

            {Console.WriteLine ("Lower"); }

            else 
            {Console.WriteLine ("You guessed it!"); }

        }


    }
}