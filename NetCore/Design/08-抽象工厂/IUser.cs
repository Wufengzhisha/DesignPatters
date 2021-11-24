public interface IUser
{
    void Insert(User user);
    void GetUser(int id);
}


public class  SqlserverUser:IUser
{
    public void Insert(User user)
    {
        Console.WriteLine("在 Sql server中插入一条数据");
    }

    public void GetUser(int id)
    {
        Console.WriteLine("在 Sql server中根据id获得UserInfo的数据");
    }
}

public class  AccessUser:IUser
{
    public void Insert(User user)
    {
        Console.WriteLine("在 Access 中插入一条数据");
    }

    public void GetUser(int id)
    {
        Console.WriteLine("在 Access 中根据id获得UserInfo的数据");
    }
}