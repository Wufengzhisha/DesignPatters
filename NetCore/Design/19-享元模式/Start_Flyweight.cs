public class Start_Flyweight
{
    public void Go()
    {
        int extrinsicstate = 22;
        FlyweightFactory f = new FlyweightFactory();

        Flyweight fx = f.GetFlyweight("x");
        fx.Operation(--extrinsicstate);

        Flyweight fy = f.GetFlyweight("y");
        fx.Operation(--extrinsicstate);

        Flyweight fz = f.GetFlyweight("z");
        fx.Operation(--extrinsicstate);

        UnsharedConcreteFlyweight uf = new UnsharedConcreteFlyweight();
        uf.Operation(--extrinsicstate);
    }
}