public class Person
{

    public Person(){}
    public string name = string.Empty ;
    public Person(string name)
    {
        this.name = name;
    }

    public virtual void Show()
    {
      Console.WriteLine("装扮的{0}",name);  
    }
}


//服饰类
public class Finery:Person
{
    protected Person component = new Person();

    public void Decorate(Person component)
    {
        this.component = component;        
    }

    public override void Show()
    {
        if (component != null)
        {
            component.Show();
        }
    }
}


public class TShirts :Finery
{
    public override void Show()
    {
        Console.Write("大T恤 ");
        base.Show();
    }
}

public class BigTrouser :Finery
{
    public override void Show()
    {
        Console.Write("垮裤 ");
        base.Show();
    }
}

public class WearSneakers :Finery
{
    public override void Show()
    {
        Console.Write("破球鞋 ");
        base.Show();
    }
}