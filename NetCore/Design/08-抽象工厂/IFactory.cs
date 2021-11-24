public interface IFactory
{
    IUser CreateUser();
}


public class  SqlserverFactory:IFactory
{
    public IUser CreateUser()
    {
        return  new SqlserverUser();
    }
}


public class  AccessFactory:IFactory
{
    public IUser CreateUser()
    {
        return  new AccessUser();
    }
}