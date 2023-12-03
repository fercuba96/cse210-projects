public abstract class Goal

{
    protected string _description= "";
    protected string _shortname= "";
    protected int _points = 0;
    protected bool _iscomplete;

    public string Getnameofgoal()
    {
        return _shortname;
    }
    
    public void Setnameofgoal(string shortname)
    {
        _shortname= shortname;
    }


    public string Getdescription()
    {
        return _description;
    }

    public void Setdescription( string description)
    {
        _description = description;
    }

    public void Getnameofgoalquestion()

    {
       Console.WriteLine("Give a name to this goal:");

    }

    public void Getdescriptionfgoalquestion()

    {
       Console.WriteLine("Explain this goal:");

    }


    public void Getpoints()

    {
       Console.WriteLine("How many points are for this goal?");

    }

    public string DisplayStartingMessage()

    {
        return $" Welcome to the {_shortname}! \nConsider the following: \n{_description}";
    }

    public int Getpointstring()
    {
        return _points;
    }

    public void Setpointtodisplay(int pointsforgoal)
    {
        _points = pointsforgoal;

    }

    public string Displayendingmessage()

    {
        return $"\nWell done! \nYou have completed {_points} seconds of  {_shortname}!!!";
    }

    public abstract void Iscomplete();
    //{
    //    return -1; 
    //}
    public abstract string GetStringRepresentation();

    public abstract void RecordEvent();

}