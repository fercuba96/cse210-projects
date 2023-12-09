public class comments
{   
    public string userofcomment {get; set;}
    public string dateofcomment {get; set;}
    public string commentsofuser {get; set;}

    private List<string>_video1comments = new List<string>();
    private List<string>_video2comments = new List<string>();
    private List<string>_video3comments = new List<string>();
    private List<string>_video4comments = new List<string>();

    //theJournal.AddEntry(_thoughts);


    public void AddComment1(string userofcomment, string dateofcomment, string commentsofuser)

    {
        string newComment = GetComment(userofcomment, dateofcomment,commentsofuser);
        _video1comments.Add(newComment);
    }

    public void AddComment2(string userofcomment, string dateofcomment, string commentsofuser)

    {
        string newComment = GetComment(userofcomment,dateofcomment,commentsofuser);
        _video2comments.Add(newComment);
    }

    public void AddComment3(string userofcomment,string dateofcomment, string commentsofuser)

    {
        string newComment = GetComment(userofcomment,dateofcomment,commentsofuser);
        _video3comments.Add(newComment);
    }

    public void AddComment4(string userofcomment, string dateofcomment, string commentsofuser)

    {
        string newComment = GetComment(userofcomment,dateofcomment,commentsofuser);
        _video4comments.Add(newComment);
    }

    public string GetComment(string userofcomment, string dateofcomment, string commentsofuser)
    {
       return $"\nUser: {userofcomment} on {dateofcomment}\nCommented: {commentsofuser}\n";
    }

    public void Displaycomments1()
    {
       foreach (string comments1 in _video1comments)
       {
           Console.WriteLine(comments1);
       }
    }

    public void Displaycomments2()
    {
       foreach (string comments2 in _video2comments)
       {
           Console.WriteLine(comments2);
       }
    }
    public void Displaycomments3()
    {
       foreach (string comments3 in _video3comments)
       {
           Console.WriteLine(comments3);
       }
    }
    public void Displaycomments4()
    {
       foreach (string comments4 in _video4comments)
       {
           Console.WriteLine(comments4);
       }
    }


}