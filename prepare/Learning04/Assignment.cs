

public class Assignment 

{
   protected string _studentname = "";
   protected string _coursename =  "";
   
   public string GetStudentname ()
   {
    return _studentname;
   }

   public void SetStudentname (string studentname)
   {
      _studentname = studentname;
   }

   public string GetCoursename ()
    { 
        return _coursename;
    }
    public void SetCoursename( string coursename)

    {
        _coursename = coursename;
    }

    public string GetSummaryinfo()

    {
        return $"{_studentname} - {_coursename}";
    }

}