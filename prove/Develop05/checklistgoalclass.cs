public class checklistgoal : Goal 
{     
    private int _timestocomplete = 0;
    private bool _iscomplete = false;
    public int Gettimesforgoal()
    {
        return _timestocomplete;
    }

    public void Settimesforgoal(int timestocomplete)
    {
        _timestocomplete = timestocomplete;

    }

    public override void Iscomplete()
    {
        _iscomplete= true; 
    }

    public override string GetStringRepresentation()
    {
        string completionStatus = _iscomplete ? "[X]" : "[ ]";
        return $"{completionStatus} {_shortname} : {_description} -{_points} points- Times done: {_timestocomplete}" ;
    }

    public override void Iscomplete(bool _iscomplete)
    {
        return true; 
    }

}