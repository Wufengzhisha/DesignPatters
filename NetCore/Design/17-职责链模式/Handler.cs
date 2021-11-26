namespace Duties_Model;

public abstract class Handler
{
    protected Handler ? successor;
    public void SetSuccessor(Handler successor) //设置继任者
    {
        this.successor = successor;
    }

    public abstract void HandleRequest(int request);
}

public class ConcreteHandler1:Handler
{
    public override void HandleRequest(int request)
    {
        if (request >=0 && request <10)
        {
            Console.WriteLine("{0} 处理请求 {1}",this.GetType().Name,request);
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);    
        }
    }

}

public class ConcreteHandler2:Handler
{
    public override void HandleRequest(int request)
    {
        if (request >=10 && request <20)
        {
            Console.WriteLine("{0} 处理请求 {1}",this.GetType().Name,request);
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);    
        }
    }

}
