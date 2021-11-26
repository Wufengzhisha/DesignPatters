namespace Design_Mediator;

public abstract class Mediator
{
    public abstract void Send(string message,Colleague colleague);
}

public class ConcreteMediator: Mediator
{

    private ConcreteColleague1 ? concreteColleague1;
    private ConcreteColleague2 ? concreteColleague2;

    public ConcreteColleague1 Colleague1
    {
        set{concreteColleague1=value;}
    }

    public ConcreteColleague2 Colleague2
    {
        set{concreteColleague2=value;}
    }


    public override void Send(string message,Colleague colleague)
    {
        if (colleague == concreteColleague1)
        {
            if(concreteColleague2!=null)
            concreteColleague2.Notify(message);
        }
        else
        {
            if(concreteColleague1!=null)
            concreteColleague1.Notify(message);
        }
    }
} 