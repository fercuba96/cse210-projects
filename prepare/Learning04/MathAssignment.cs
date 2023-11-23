
public class MathAssigment : Assignment

 {
    private string _sectionclass = "";
    private string _problemsmath = "";

    public string GetSectionclass() 

    {
        return _sectionclass;
    }
    
    public void SetSectionclass (string sectionclass)

    {
        _sectionclass = sectionclass;
    }

    public string GetProblems()

    {
        return _problemsmath;
    }
    public void Setproblems ( string problemsmath)

    {
        _problemsmath = problemsmath;
    }

    public string GetHomeworkList()

    {
        return $"{_studentname} - {_coursename} \n{_sectionclass} {_problemsmath}";
    }

}