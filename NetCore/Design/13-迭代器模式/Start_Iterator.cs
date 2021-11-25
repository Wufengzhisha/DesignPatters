public class Start_Iterator:IStart
{
    public void Go()
    {
        ConcreteAggregate a = new ConcreteAggregate();
        a[0] = "A";
        a[1] = "B";
        a[2] = "c";
        Iterator i = new ConcreteIterator(a);
        object item = i.First();
        while (!i.IsDone())
        {
             Console.WriteLine("{0} 请买车票！",i.CurrentItem());
             i.Next();
        }

    }
}