public abstract class State
{
    public abstract void WriteProgram(Work work);
}

public class ForenoonState:State
{
    public override void WriteProgram(Work work)
    {
        if (work.Hour <12)
        {
            Console.WriteLine("当前时间：{0}点，上午工作，精神百倍");
        }
        else
        {
            work.SetState(new NoonState());
            work.WriteProgram();
        }
    }
}

public class NoonState:State
{
    public override void WriteProgram(Work work)
    {
        throw new NotImplementedException();
    }
}