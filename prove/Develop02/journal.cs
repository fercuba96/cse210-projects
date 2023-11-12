
// AddEntry(newEntry : Entry) : void
// DisplayAll() : void
// SaveToFile(file : string)
//LoadFromFile(file : string)
class Journal

{
  private Data database; 
  
  public Journal()

  {
   database = new Data ();
  }

  public void PrintEntries()

  {

    database.Display();
       
  }

  public void Promptquest()
  {
   Promptgenerator prompt = new Promptgenerator();
   prompt.GetRandomPrompt();

  }
  public void AddEntry()

  {      
         Console.WriteLine ("Enter the date");
         string date = Console.ReadLine ();
         string promptText1 = "What is your main goal?";
         Console.WriteLine ("Enter the entry text:");
         string entryText = Console.ReadLine ();
         database.AddEntry(date, promptText1 , entryText);
      
  }


}