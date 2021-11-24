public class RoleStateMemento
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
    


    public RoleStateMemento(int vit,int atk ,int def)
    {
        this.vit = vit;
        this.atk = atk;
        this.def = def;
    }

}