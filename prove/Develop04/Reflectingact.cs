public class Reflectingact : Activity
{

    public void GetRandomQuestionforact()
  
  {

    List<string> _words = new List<string>(new string [] { "How you get to that situation?" , "Would you do something different?", "What is the main learning from that experience?","Have you felt any change in you since then?"});
    Random R = new Random(); 
        int someRandomprompt = R.Next(0,_words.Count());

     Console.WriteLine("\n>>Please answer in your mind: {0}", _words.ElementAt(someRandomprompt));
  }

public void GetRandomPromptforact()
  
  {

    List<string> _words = new List<string>(new string [] { "Think in the most difficult thing you have done." , "Remember your favorite moment last year.", "Picture the happiest moment that you have.","Have in mind the stresful moment this year 2023"});
    Random R = new Random(); 
        int someRandomprompt = R.Next(0,_words.Count());

     Console.WriteLine("\nPrompt: {0}", _words.ElementAt(someRandomprompt));
  }




}