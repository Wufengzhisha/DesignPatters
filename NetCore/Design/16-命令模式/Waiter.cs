public class Waiter
{
    private Command ?command;
    public void SetOrder(Command command)
    {
        this.command = command;
    }

    public void Notify()
    {
        if(command!=null)
        command.ExcuteCommand();
    }
}