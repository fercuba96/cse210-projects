using System;

class Entry

{
    public string _date {get; set;}
    public string _promptText {get; set;}
    public string _entryText {get; set;}
    public Entry (string date, string promptText, string entryText )
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }
    // got this code from https://www.ictdemy.com/csharp/oop/diary-with-a-database-in-csharp-net
    public override string ToString()
    {
        return _date + "" + _promptText + _entryText;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} {_promptText} {_entryText}");
    }
}