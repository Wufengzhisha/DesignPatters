using System.IO;

public class B_Startup
{
    private string path = @"D:\c#\video";

    private string new_path = @"D:\c#\video_1";
    public void Go()
    {
        DirectoryInfo directory = new DirectoryInfo(path);
        foreach(var item in directory.GetDirectories())
        {
        
           string filename = item.Name ?? "1";
           DirectoryInfo _dir = new DirectoryInfo(item.FullName);
           foreach (var _item in _dir.GetFiles())
           {
             if (_item.FullName.ToLower().Contains(".mp4"))
             {
                 File.Copy(_item.FullName,Path.Combine(new_path,string.Format("P-{0}.mp4",filename)));
             }  
           } 

        }
    }
}