public abstract class Iterator
{
    public abstract object First();
    public abstract object Next();
    public abstract bool IsDone();
    public abstract object CurrentItem();
}

public class ConcreteIterator:Iterator
{
    private ConcreteAggregate aggregate;
    private int current = 0;
    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this.aggregate = aggregate;
    }
    public override object First()
    {
        return aggregate[0];
    }
    public override object Next()
    {
        object ret = new object();
        current++;
        if (current <aggregate.Count)
        {
            ret = aggregate[current];
        }
        return ret;
    }
    public override bool IsDone()
    {
        return current >= aggregate.Count?true:false;
    }

    public override object CurrentItem()
    {
        return aggregate[current];
    }
}