public abstract class Player
{
    public string name { get; set; }
    public Player(string name)
    {
        this.name = name;
    }

    public abstract void Attack();
    public abstract void Defense();
}


public class  Forwards:Player
{
    public Forwards(string name):base(name)
    {
    }

    public override void Attack()
    {
        Console.WriteLine("前锋 {0} 进攻",name);
    }

    public override void Defense()
    {
        Console.WriteLine("前锋 {0} 防守",name);
    }
}