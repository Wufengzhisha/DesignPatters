public class GameRole
{
   private int vit;
    public int Vitality
    {
        get { return vit; }
        set { vit = value; }
    }

    private int def;
    public int Defense
    {
        get { return def; }
        set { def = value; }
    }

    private int atk;
    public int Attack
    {
        get { return atk; }
        set { atk = value; }
    }


    public RoleStateMemento SaveState()
    {
        return (new RoleStateMemento(vit,atk,def));
    }
    
    public void RecoveryState(RoleStateMemento memento)
    {
        this.vit = memento.Vitality;
        this.atk = memento.Attack;
        this.def = memento.Defense;
    }

    public void StateDisplay()
    {
        Console.WriteLine("当前角色状态：体力{0}，攻击力{1}，防御力{2}",this.vit,this.atk,this.def);
    }

    public void GetIniState()
    {
        this.vit = 100;
        this.atk = 100;
        this.def = 100;
    }

    public void Fight()
    {
        this.vit = 0;
        this.atk = 0;
        this.def = 0;
    }
}