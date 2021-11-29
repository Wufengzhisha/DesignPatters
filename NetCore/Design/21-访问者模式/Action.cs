abstract class Action
{
    public abstract void GetManConclusion(Man man);
    public abstract void GetWomanConclusion(Woman woman);
}
abstract class Human
{
    //接受状态
    public abstract void Accept(Action visitor);
}

class Man:Human
{
    public override void Accept(Action visitor)
    {
        throw new NotImplementedException();
    }
}

class Woman:Human
{
    public override void Accept(Action visitor)
    {
        throw new NotImplementedException();
    }
}


class Success:Action
{
    public override void GetManConclusion(Man man)
    {
      Console.WriteLine("{0} {1}，时，背后多半有一个伟大的女人",man.GetType().Name,this.GetType().Name);
    }

    public override void GetWomanConclusion(Woman woman)
    {
        throw new NotImplementedException();
    }
}