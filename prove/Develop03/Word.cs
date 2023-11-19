public class Word 
 {
 string _text = "Lets work on this";

 string _wordtoreplace;
 string Hideline= "____";
  
 public void Hide(string _wordtoreplace)
 {
   string Hiddentext = _text.Replace(_wordtoreplace, "____" );
   Console.WriteLine(Hiddentext);
}
bool value = true;
public void IsHidden(string _wordtoreplace)
{
     if (_wordtoreplace == "____")
      {
         value = true;
      }
     else {
        value = false;
     }
}

//public Display()

 }
