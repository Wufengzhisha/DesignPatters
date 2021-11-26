
public abstract class Manager
{
    protected string ? name;
    protected Manager ? superior;

    public Manager(string name)
    {
        this.name =name;
    }

    public void SerSuperior(Manager superior)
    {
        this.superior = superior;
    }

    abstract public void ResquestApplications(Request request);
}

public class CommanManger:Manager
{
    public CommanManger(string name):base(name){}
    public override void ResquestApplications(Request request)
    {
        if (request.RequestType=="请假" && request.Number<=2)
        {
            Console.WriteLine("{0}:{1} 数量{2}被批准",name,request.RequestContent,request.Number);
        }
        else if (superior!=null)
        {
             superior.ResquestApplications(request);
        }
    }
}

public class Majordomo:Manager
{
    public Majordomo(string name):base(name){}
    public override void ResquestApplications(Request request)
    {
        if (request.RequestType=="请假" && request.Number<=5)
        {
            Console.WriteLine("{0}:{1} 数量{2}被批准",name,request.RequestContent,request.Number);
        }
        else if (superior!=null)
        {
             superior.ResquestApplications(request);
        }
    }
}

public class GeneraManager:Manager
{
    public GeneraManager(string name):base(name){}
    public override void ResquestApplications(Request request)
    {
        if (request.RequestType=="请假")
        {
            Console.WriteLine("{0}:{1} 数量{2}被批准",name,request.RequestContent,request.Number);
        }
        else if(request.RequestType=="加薪" && request.Number<=500)
        {
            Console.WriteLine("{0}:{1} 数量{2}被批准",name,request.RequestContent,request.Number);
        }
        else if(request.RequestType=="加薪" && request.Number>500)
        {
            Console.WriteLine("{0}:{1} 数量{2} 再说吧",name,request.RequestContent,request.Number);
        }
    }
}