public class Activity 

{
    protected string _instructionact = "";
    protected string _nameofact = "";
    protected int _timeofact = 0;

    public string Getnameofact()
    {
        return _nameofact;
    }
    
    public void Setnameofact(string nameofact)
    {
        _nameofact = nameofact;
    }


    public string Getinstructions()
    {
        return _instructionact;
    }

    public void Setinstructions( string intrusctionact)
    {
        _instructionact = intrusctionact;
    }

    public void Gettimeforact()

    {
       Console.WriteLine("How long in seconds this session you would like to have?");

    }

    public string DisplayStartingMessage()

    {
        return $" Welcome to the {_nameofact}! \nConsider the following: \n{_instructionact}";
    }

    public void GetReadymessag()

    {
        Console.WriteLine("Get Ready.....");
    }

    public int Gettimeforstring()
    {
        return _timeofact ;
    }

    public void Settimefordisplay(int timeofact)
    {
        _timeofact = timeofact;

    }

    public string Displayendingmessage()

    {
        return $"\nWell done! \nYou have completed {_timeofact} seconds of  {_nameofact}!!!";
    }

    public void CountDownInt(int timeinsecforcount)
    {
      for (int i = timeinsecforcount; i > 0; i--)
      {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
      }

    }

    public void ShowSpinner(int spinnertime)
    {
       List<string> animationswithstring = new List<string>();
       animationswithstring.Add("|");
       animationswithstring.Add("/");
       animationswithstring.Add("-");
       animationswithstring.Add("\\");
       animationswithstring.Add("|");
       animationswithstring.Add("/");
       animationswithstring.Add("-");
       animationswithstring.Add("\\");

       DateTime startime = DateTime.Now;
       DateTime endTime = startime.AddSeconds(spinnertime);

       int i = 0;

       while (DateTime.Now < endTime)
       {
        string s = animationswithstring[i];
        Console.Write(s);
        Thread.Sleep(1000);
        Console.Write("\b \b");

        i++;

        if( i >= animationswithstring.Count)

        {
            i=0;
        }
       }
    }

}   