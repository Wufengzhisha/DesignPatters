namespace Design_Mediator;

public class Start_Mediator
{
    public void Go()
    {
        ConcreteMediator m = new ConcreteMediator();
        ConcreteColleague1 c1 = new ConcreteColleague1(m);
        ConcreteColleague2 c2 = new ConcreteColleague2(m);

        m.Colleague1 = c1;
        m.Colleague2 = c2;

        c1.Send("吃过饭了吗？");
        c2.Send("没，你打算请？");
    }
}