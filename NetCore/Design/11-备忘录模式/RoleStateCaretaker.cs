public class  RoleStateCaretaker
{
    private RoleStateMemento memento = new RoleStateMemento(0,0,0);
    public RoleStateMemento Memento
    {
        get { return memento; }
        set { memento = value; }
    }
    
}