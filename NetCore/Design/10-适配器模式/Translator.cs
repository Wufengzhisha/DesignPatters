public class Translator:Player
{
    private ForeignCenter wx = new ForeignCenter();
    public Translator(String name):base(name)
    {
        wx.Name = name;
    }

    public override void Attack()
    {
        wx.进攻();
    }

    public override void Defense()
    {
         wx.防守();
    }
}