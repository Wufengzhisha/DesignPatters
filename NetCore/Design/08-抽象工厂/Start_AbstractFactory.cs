public class  Start_AbstractFactory:IStart
{
    public void Go()
    {
        User user = new User();

        IFactory factory = new SqlserverFactory();
        IUser iu = factory.CreateUser();

        iu.Insert(user);
    }
}