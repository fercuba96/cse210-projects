public class Displayact

{
    public void Breathingacttodisplay()

    {
       //string timeinsec1 = "";
           Breathingact breathact1 = new Breathingact();
           breathact1.Setnameofact("Breathing Activity");
           breathact1.Setinstructions("You will have seconds to breath, Please take it the most seriously as possible. Please enter to continue.");
           breathact1.Gettimeforact();           
           string timeinsecString = Console.ReadLine();

        // Convert the string to an integer
        if (int.TryParse(timeinsecString, out int timeinsec))
        {
            Console.WriteLine(breathact1.DisplayStartingMessage());
            Console.ReadLine();
            Console.Clear();
            breathact1.Settimefordisplay(timeinsec);
            breathact1.GetReadymessag();
            Console.Write("\nBreath in...");
            breathact1.CountDownInt(timeinsec/4);
            Console.Write("\nBreath out...");
            breathact1.CountDownInt(timeinsec/4);
            Console.Write("\nBreath in...");
            breathact1.CountDownInt(timeinsec/4);
            Console.Write("\nBreath out...");
            breathact1.CountDownInt(timeinsec/4);
            Console.WriteLine("\nWell Done!");
            breathact1.ShowSpinner(4);
            Console.WriteLine(breathact1.Displayendingmessage());
        }
        else
        {
            Console.WriteLine("Invalid input for time. Please enter a valid number.");
        }

    }
  
    public void Reflectingacttodisplay()
    {
        Reflectingact reflectact1 = new Reflectingact();
             reflectact1.Setnameofact("Reflecting Activity");
             reflectact1.Setinstructions("You will have seconds to choose a meaning experience. Then answer the questions.");
             reflectact1.Gettimeforact();           
             string timeinsecString = Console.ReadLine();
//
    //    // Convert the string to an integer
             if (int.TryParse(timeinsecString, out int timeinsec))
         {
              Console.WriteLine(reflectact1.DisplayStartingMessage());
              reflectact1.Settimefordisplay(timeinsec);
              reflectact1.GetReadymessag();
              reflectact1.ShowSpinner(3);
              Console.WriteLine("\nConsider the following prompt:");
              reflectact1.GetRandomPromptforact();
              Console.WriteLine("\nWhen you have a clear picture of that moment press Enter");
              Console.ReadLine();
              Console.Clear();
              reflectact1.GetRandomQuestionforact();
              reflectact1.ShowSpinner(timeinsec/2);
              reflectact1.GetRandomQuestionforact();
              reflectact1.ShowSpinner(timeinsec/2);
              reflectact1.CountDownInt(3);
              Console.WriteLine(reflectact1.Displayendingmessage());
           }
           else
           {
               Console.WriteLine("Invalid input for time. Please enter a valid number.");
           }

    }


}