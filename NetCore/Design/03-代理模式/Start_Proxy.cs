public class Start_Proxy : IStart
{
  public void Go()
  {
    SchoolGirl zq = new SchoolGirl();
    zq.Name = "张庆";

    Proxy gg = new Proxy(zq);
    gg.GiveDolls();
    gg.GiveFlowers();

  }
}