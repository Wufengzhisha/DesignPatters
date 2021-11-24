public class Work
{

    private State current ;

    public Work()
    {
        current = new ForenoonState();
    }

    private int hour;
    public int Hour
    {
        get { return hour; }
        set { hour = value; }
    }

    private bool finish;
    public bool Finish
    {
        get { return finish; }
        set { finish = value; }
    }

    public void SetState(State state)
    {
        current = state;
    }
    
    public void WriteProgram()
    {
        current.WriteProgram(this);
    }
    
}