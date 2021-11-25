public abstract class HandsetBrand
{
    protected HandsetSoft ?soft;
    public void SetHandsetSoft(HandsetSoft soft)
    {
        this.soft = soft;
    }

    public abstract void Run();
}

public class HandsetBrandN:HandsetBrand
{
    public override void Run()
    {
        if(soft != null)
            soft.Run();
    }
}

public class HandsetBrandM:HandsetBrand
{
    public override void Run()
    {
        if(soft != null)
            soft.Run();
    }
}