public class Listingactivity : Activity

{
    public void GetRandomPromptforlist()
  
  {

    List<string> _words = new List<string>(new string [] { "Think in the most difficult thing you have done." , "Remember your favorite moment last year.", "Picture the happiest moment that you have.","Have in mind the stresful moment this year 2023"});
    Random R = new Random(); 
        int someRandomprompt = R.Next(0,_words.Count());

     Console.WriteLine("\nTopic: {0}", _words.ElementAt(someRandomprompt));
  }

  public void GetListfromuser(int collecttime)
   { 
    List<string> prompts = new List<string>();
    DateTime startime = DateTime.Now;
    DateTime endTime = startime.AddSeconds(collecttime);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter a prompt: ");
            string userPrompt = Console.ReadLine();

            prompts.Add(userPrompt);
        }

        Console.WriteLine($"Number of prompts collected: {prompts.Count}");
   }

  //  protected List<string> prompts;
//
  //  public PromptCollector()
  //  {
  //      prompts = new List<string>();
  //  }
//
  //  public virtual void CollectPrompt()
  //  {
  //      Console.Write("Enter a prompt: ");
  //      string userPrompt = Console.ReadLine();
  //      prompts.Add(userPrompt);
  //  }

   // public void DisplayPromptCount()
   // {
   //     Console.WriteLine($"Number of prompts collected: {prompts.Count}");
   // }
}



