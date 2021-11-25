public class Start_Command
{
    public void Go()
    {
        Barbecue boy = new Barbecue();
        Command command1 = new BakeMuttonCommand(boy);
        Command command2 = new BakeChickenCommand(boy);
        Waiter girl = new Waiter();

        girl.SetOrder(command1);
        girl.Notify();
        girl.SetOrder(command2);
        girl.Notify();
    }
    
}