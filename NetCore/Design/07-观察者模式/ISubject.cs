public interface ISubject
{
    void Attach(ObServer obServer);
    void Detach(ObServer obServer);
    void Notify();
    string SubjectState
    {
        get;set;
    }
}