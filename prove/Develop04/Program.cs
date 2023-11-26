using System;

class Program
{
    static void Main(string[] args)
    {

        //option 1
      //  Displayact Displayact1 = new Displayact();
      //  Displayact1.Breathingacttodisplay();

      //option 2
     // Displayact Displayact2 = new Displayact();
     // Displayact2.Reflectingacttodisplay();
     ////     
               Listingactivity listingact1 = new Listingactivity();
               listingact1.Setnameofact("Listing Activity");
               listingact1.Setinstructions("You will have seconds to list your prompts.");
               listingact1.Gettimeforact();           
               string timeinsecString = Console.ReadLine();
////
    ////    // Convert the string to an integer
             if (int.TryParse(timeinsecString, out int timeinsec))
          {
             Console.WriteLine(listingact1.DisplayStartingMessage());
             listingact1.Settimefordisplay(timeinsec);
             listingact1.GetReadymessag();
             listingact1.ShowSpinner(3);
             Console.WriteLine("\nConsider the following prompt:");
             listingact1.GetRandomPromptforlist();
             Console.WriteLine("\nEnter your prompts:");
             private List<string> prompts;

             public PromptCollector()
            {
               prompts = new List<string>();
            }
             listingact1.CollectPrompt();
             listingact1.CollectPrompt();
             listingact1.DisplayPromptCount();
    //          Console.ReadLine();
    //          Console.Clear();
    //          reflectact1.GetRandomQuestionforact();
    //          reflectact1.ShowSpinner(timeinsec/2);
    //          reflectact1.GetRandomQuestionforact();
    //          reflectact1.ShowSpinner(timeinsec/2);
    //          reflectact1.CountDownInt(3);
          Console.WriteLine(listingact1.Displayendingmessage());
           }
          else
            {
               Console.WriteLine("Invalid input for time. Please enter a valid number.");
          }
       }
}