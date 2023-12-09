public class video

{
    public string _authorofvideo {get; set;}
    public string _descriptionofvideo {get; set;}
    public string _lenghtofvideo {get; set;}
    public void Video (string authorofvideo, string descriptionofvideo, string lenghtofvideo )
    {
        _authorofvideo = authorofvideo;
        _descriptionofvideo = descriptionofvideo;
        _lenghtofvideo = lenghtofvideo;
    }

    public void Displayvideoinfo()
    {
       Console.WriteLine($"Created by: {_authorofvideo}\nDescription:{_descriptionofvideo}\nDuration of video: {_lenghtofvideo}");
    }

}