public class Secretary
{

    private IList<StockObserver> observers = new List<StockObserver>();
    private string action = string.Empty;
    public void Attach(StockObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(StockObserver obServer)
    {
        observers.Remove(obServer);
    }

    public void Notify()
    {
        foreach (var item in observers)
        {
            item.Update();
        }
    }

    public string SecretaryAction
    {
        get{return action;}
        set{ action = value;}
    }
}


public class Boss:ISubject
{
      private IList<ObServer> observers = new List<ObServer>();
    private string action = string.Empty;
    public void Attach(ObServer observer)
    {
        observers.Add(observer);
    }

    public void Detach(ObServer obServer)
    {
        observers.Remove(obServer);
    }

    public void Notify()
    {
        foreach (var item in observers)
        {
            item.Update();
        }
    }

    public string SubjectState
    {
        get{return action;}
        set{ action = value;}
    }
}