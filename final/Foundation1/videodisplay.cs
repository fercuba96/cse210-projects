public class videodisplay
{  
  //comments infocomment; 
  private comments Comment1;
  private comments Comment2 ;
  private comments Comment3;
  private comments Comment4;
  public videodisplay()

  {
   //infocomment = new comments ();
   Comment1 = new comments();
   Comment2 = new comments();
   Comment3 = new comments();
   Comment4 = new comments();
  }

  public void Getcommentinfo1()
  {
    Comment1.Displaycomments1();    
  }
  public void Getcommentinfo2()
  {
    Comment2.Displaycomments2();   
  }

  public void Getcommentinfo3()
  {
    Comment3.Displaycomments3();    
  }
  public void Getcommentinfo4()
  {
    Comment4.Displaycomments4();    
  }

    public void video1info()
    {
        video video1 = new video();
        video1.Video("Camilo", "It is about me.","14 min" );
        video1.Displayvideoinfo();
    } 

    public void video2info()
    {
        video video2 = new video();
        video2.Video("Charizar", "It is about pokemon.","11 min" );
        video2.Displayvideoinfo();
    } 

    public void video3info()
    {
        video video3 = new video();
        video3.Video("Julia Verna", "It is about Apple Inc.","10 min" );
        video3.Displayvideoinfo();
    } 

    public void video4info()
    {
        video video4 = new video();
        video4.Video("Kiko", "It is about Marvel.","16 min" );
        video4.Displayvideoinfo();
    } 
    
    public void commentforvideo1()
    {
    
        Console.WriteLine ("Enter comment about this video");
        string commentofuser = Console.ReadLine ();
        Console.WriteLine("What is your user name?");
        string userofcomment = Console.ReadLine();
        Console.WriteLine ("When is this comment is done?");
        string dateofcomment = Console.ReadLine ();
        Comment1.AddComment1(userofcomment,dateofcomment,commentofuser);
        
    }

    public void commentforvideo2()
    {
        //comments Comment2 = new comments();
        Console.WriteLine ("Enter comment about this video");
        string commentofuser = Console.ReadLine ();
        Console.WriteLine("What is your user name?");
        string userofcomment = Console.ReadLine();
        Console.WriteLine ("When is this comment is done?");
        string dateofcomment = Console.ReadLine ();
        Comment2.AddComment2(userofcomment,dateofcomment,commentofuser);
        
    }

    public void commentforvideo3()
    {
        //comments Comment3 = new comments();
        Console.WriteLine ("Enter comment about this video");
        string commentofuser = Console.ReadLine ();
        Console.WriteLine("What is your user name?");
        string userofcomment = Console.ReadLine();
        Console.WriteLine ("When is this comment is done?");
        string dateofcomment = Console.ReadLine ();
        Comment3.AddComment3(userofcomment,dateofcomment,commentofuser);
        
    }

    public void commentforvideo4()
    {
        //comments Comment4 = new comments();
        Console.WriteLine ("Enter comment about this video");
        string commentofuser = Console.ReadLine ();
        Console.WriteLine("What is your user name?");
        string userofcomment = Console.ReadLine();
        Console.WriteLine ("When is this comment is done?");
        string dateofcomment = Console.ReadLine ();
        Comment4.AddComment4(userofcomment,dateofcomment,commentofuser);
        
    }

}