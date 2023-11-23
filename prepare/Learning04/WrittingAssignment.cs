
public class WrittingAssignment : Assignment
{
   protected string _titleofbook = "";

   public string GetTitleofbook()
   {
     return _titleofbook; 
   }

   public void SetTitleofbook (string titleofbook)
   {
      _titleofbook = titleofbook;
   }

   public string GetWrittinginfo()

   {
      return $"{_studentname} - {_coursename} \n{_titleofbook} by {_studentname}";
   }

}