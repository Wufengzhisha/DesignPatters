using System.Collections;


public class FlyweightFactory
{
    private Hashtable flyweights  = new Hashtable();
    public FlyweightFactory()
    {
        flyweights.Add("x",new ConcreteFlyweight());
        flyweights.Add("y",new ConcreteFlyweight());
        flyweights.Add("z",new ConcreteFlyweight());
    }

    public Flyweight  GetFlyweight(string key)
    {
        var f = flyweights[key];

        return((Flyweight)(f ?? new ConcreteFlyweight()));
    }
}