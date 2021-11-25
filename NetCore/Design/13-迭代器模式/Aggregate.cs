//聚集抽象类
public abstract class Aggregate
{
    //创建迭代器
    public abstract Iterator CreateIterator();
}

public class ConcreteAggregate:Aggregate
{
    private IList<object>  items = new  List<object>();
    public override Iterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }

    public int Count
    {
        get{return items.Count;}
    }

    public object this[int index]
    {
        get { return items[index]; }
        set { items.Insert(index,value); }
    }

}