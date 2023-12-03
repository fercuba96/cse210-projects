public class eternalgoalclass : Goal 

{
    private bool _iscomplete = false;

    public override string GetStringRepresentation()
    {   
        string completionStatus = _iscomplete ? "[X]" : "[ ]";
        return $"{completionStatus} {_shortname} : {_description} with {_points} points ";
    }

    public override void Iscomplete()
    {
        _iscomplete= false; 
    }
}
