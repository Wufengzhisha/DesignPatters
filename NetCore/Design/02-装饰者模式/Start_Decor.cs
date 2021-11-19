public class Start_Decor:IStart
{
    public void Go()
    {
         Person xc = new Person("Saber");
         TShirts t1 = new TShirts();
         BigTrouser t2 = new BigTrouser();

         t1.Decorate(xc);
         t2.Decorate(t1);
         t2.Show();
    }
}