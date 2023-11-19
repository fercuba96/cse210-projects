public class Reference
{
     private string _book;
     private int _chapter;
     private int _verse;
     private int _endverse;
     
    public void Writeference(string book, int chapter, int verse, int endverse)

     {
        _book = "Proverbs";
        _chapter = 4;
        _verse = 5;
        _endverse = 6;
     }


    public string GetDisplayText()
    {
       return _book +"" + _chapter+ ":" + _verse + "-" + _endverse + ":";

    }

}