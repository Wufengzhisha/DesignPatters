public class Start_Observer:IStart
{
    public void Go()
    {
        Boss zq = new  Boss();
        StockObserver wx = new StockObserver("Saber",zq);

        zq.Attach(wx);

        zq.SubjectState = "老板来了";
        zq.Notify();
    }
}