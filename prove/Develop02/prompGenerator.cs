
class Promptgenerator

//got information from https://www.coderschmoder.com/get-random-element-from-list-in-c-net-6-0/ to make this code:
{ 
  public string promptText;
  public void GetRandomPrompt()
  
  {

    List<string> _words = new List<string>(new string [] { "Who was the more interesting person on your day?" , "What is your greatest act of compasion of this day?", "Write the main learning of today"});
    Random R = new Random(); 
        int someRandomprompt = R.Next(0,_words.Count());

     Console.WriteLine("Please answer: {0}", _words.ElementAt(someRandomprompt));
  }
    
}