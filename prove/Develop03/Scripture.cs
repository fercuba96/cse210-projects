public class Scripture

{
   
  Reference _reference = new Reference();
   List<string> _words = new List<string>(new string [] { "Lets" , "work", "on", "this"});

public void HiddenRandomWord( string text, List<string> _words, Reference reference)
{ 
    _reference = reference;
    int qtytoHide = 1;
    int WordCount = _words.Count;
    if (qtytoHide == 1)
     { 
        bool quitLoop = false; 
        
        do

        {   Word value = new Word();
            Random HideaWord = new Random ();
            int indexToHide = HideaWord.Next(WordCount);
            if ( value.IsHidden(_words[indexToHide]) == false )
               {
                 quitLoop = false; 
                 Word _wordtoreplace = new Word(_text);
                 _words[indexToHide].SetText("___");
                 string Displayref = reference.GetDisplayText();
                 string NewText =_wordtoreplace.Show(); 
                 Console.Write(DisplayRef + NewText);

               }}

          while (quitLoop == false);
          }
      else
    {
        
    }

     }

}

//bool HiddenStrings;

//public void IscompletelyHidden()
//{
 // if (Hiddentext == "____ ____ ____ ____")
   // {
    //    HiddenStrings = true;
   // }
  //else 
    //<{
   //<     HiddenStrings = false;
  //  }







