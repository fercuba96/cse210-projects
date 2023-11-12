using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Data
{   // AddEntry(newEntry : Entry) : void
   // DisplayAll() : void
   // SaveToFile(file : string)
   //LoadFromFile(file : string)
    //private List <Entry>_thoughts
    
    //public string theJournal;
    private List<Entry>_thoughts = new List<Entry>();

    //theJournal.AddEntry(_thoughts);

    public void AddEntry(string date, string promptText, string entryText)

    {
        _thoughts.Add(new Entry(date,promptText,entryText));
    }

    public void Display()
    {
       foreach (Entry entry in _thoughts)
       {
           entry.Display();
       }
    }
}