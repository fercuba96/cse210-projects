using System;

class Program
{
    static void Main(string[] args)
    {   
        videodisplay videoinfo = new videodisplay();

        char choice = '0';


        while ( choice != '6')

        {

        Console.WriteLine("Choose the video that would like to comment:  ");
        Console.WriteLine("1. Video 1 ");
        Console.WriteLine("2. Video 2 ");
        Console.WriteLine("3. Video 3 ");
        Console.WriteLine("4. Video 4 ");
        Console.WriteLine("5. Display all comments:");
        Console.WriteLine("6. Quit");
        choice =Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (choice)

           {
            case '1':
                 videoinfo.video1info();
                 videoinfo.commentforvideo1();
                 break;
            case '2':
                 videoinfo.video2info();
                 videoinfo.commentforvideo2();
                 break;
            case '3':
                 videoinfo.video3info();
                 videoinfo.commentforvideo3();
                 break;

            case '4':
                 videoinfo.video4info();
                 videoinfo.commentforvideo4();
                 break;

            case '5':
                 Console.WriteLine("Video 1:\nComments:");
                 videoinfo.Getcommentinfo1();
                 Console.WriteLine("Video 2:\nComments:");
                 videoinfo.Getcommentinfo2();
                 Console.WriteLine("Video 3:\nComments:");
                 videoinfo.Getcommentinfo3();
                 Console.WriteLine("Video 4:\nComments:");
                 videoinfo.Getcommentinfo4();
                 break;
        

            case '6':
                 Console.WriteLine ("Press any key to quit.");
                 break;
             }
         Console.ReadKey();
         Console.Clear();
        
         }




        //video video1 = new video();
        //video1.Video("Camilo", "It is about me.","14 min" );
        //video1.Displayvideoinfo();
        //comments Comment1 = new comments();
        //Console.WriteLine ("Enter comment about this video");
        //string commentofuser = Console.ReadLine ();
        //Console.WriteLine("What is your user name?");
        //string userofcomment = Console.ReadLine();
        //Console.WriteLine ("When is this comment is done?");
        //string dateofcomment = Console.ReadLine ();
        //Comment1.AddComment1(userofcomment,dateofcomment,commentofuser);
        //Comment1.Displaycomments1();

      
    }
}