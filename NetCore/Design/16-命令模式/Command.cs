public abstract class Command
{
    protected Barbecue receiver;
    public Command(Barbecue barbecue)
    {
        this.receiver = barbecue;
    }
    abstract public void ExcuteCommand();
}

public class BakeMuttonCommand:Command
{
    public BakeMuttonCommand(Barbecue barbecue):base(barbecue){}

    public override void ExcuteCommand()
    {
        receiver.BakeMutton();
    }
}

public class BakeChickenCommand:Command
{
    public BakeChickenCommand(Barbecue barbecue):base(barbecue){}

    public override void ExcuteCommand()
    {
        receiver.BakeMutton();
    }
}
