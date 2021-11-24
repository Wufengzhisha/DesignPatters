public abstract class  ObServer
{
    protected string name = string.Empty;
    protected ISubject sub;

    public ObServer(string name,ISubject sub)
    {
        this.name = name;
        this.sub = sub;
    }

    public abstract void Update();
}

public class  StockObserver:ObServer
{
    public StockObserver(string name,ISubject sub):base(name,sub)
    {}

    public override void Update()
    {
         Console.WriteLine("{0} {1} 关闭股票行情，继续工作！",sub.SubjectState,name );
    }
}

public class  NBAObserver:ObServer
{
    public NBAObserver(string name,ISubject sub):base(name,sub)
    {}

    public override void Update()
    {
         Console.WriteLine("{0} {1} 关闭NBA，继续工作！",sub.SubjectState,name );
    }
}