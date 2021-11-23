using System.IO;
using System.Buffers;
using System.Text;

public class B_Startup
{
    private string path = @"D:\c#\video";

    private string new_path = @"D:\c#\video_1";
    public void Go()
    {
        DirectoryInfo directory = new DirectoryInfo(path);
        foreach (var item in directory.GetDirectories())
        {

            string p_name = string.Empty;
            int num = 0;
            DirectoryInfo _dir = new DirectoryInfo(item.FullName);
            foreach (var _item in _dir.GetFiles())
            {
                if (_item.FullName.ToLower().EndsWith("info"))
                {
                  p_name = GetPartName(_item.FullName);
                }
                 if (_item.FullName.ToLower().EndsWith(".mp4"))
                 {
                     File.Copy(_item.FullName,Path.Combine(new_path,string.Format("P{0}-{1}.mp4",++num,p_name)));
                 }  
            }

        }
    }


    public String GetPartName(string infoFile)
    {
        string p_name = string.Empty;
        StreamReader streamReader = new StreamReader(infoFile, Encoding.UTF8);
        string line = string.Empty;
        string sumline = string.Empty; ;
        while ((line = streamReader.ReadLine()) != null)
        {
            sumline += line.ToString();
        }
        if (!string.IsNullOrEmpty(sumline))
        {
             string[] arr =  sumline.Split(",").Where(t=>t.Contains("PartName")).ToArray();
             p_name =arr[0].Split(":")[1].Replace("\"","");

        }
        return p_name;
    }
}