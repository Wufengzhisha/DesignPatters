public class Pursuit : IGiveGift
{
  public SchoolGirl mm;
  public Pursuit(SchoolGirl mm)
  {
    this.mm = mm;
  }

  public void GiveDolls()
  {
    Console.WriteLine(mm.Name + " 送你洋娃娃");
  }

  public void GiveFlowers()
  {
    Console.WriteLine(mm.Name + " 送你鲜花");
  }

}


public class Proxy : IGiveGift
{
  Pursuit gg;
  public Proxy(SchoolGirl mm)
  {
    gg = new Pursuit(mm);
  }
  public void GiveDolls()
  {
    gg.GiveDolls();
  }

  public void GiveFlowers()
  {
    gg.GiveFlowers();
  }
}
public class SchoolGirl
{
  private string name = string.Empty;
  public string Name
  {
    get { return name; }
    set { name = value; }
  }
}