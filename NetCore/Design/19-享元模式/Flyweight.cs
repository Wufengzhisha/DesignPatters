
public abstract class  Flyweight
{
    public abstract void Operation(int extrinsicstate);
}


class ConcreteFlyweight:Flyweight
{
    public override void Operation(int extrinsicstate)
    {
       Console.WriteLine("具体Flyweight："+extrinsicstate);
    }
}

class UnsharedConcreteFlyweight:Flyweight
{
    public override void Operation(int extrinsicstate)
    {
       Console.WriteLine("不共享的具体Flyweight："+extrinsicstate);
    }
}
