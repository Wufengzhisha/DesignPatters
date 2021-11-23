public class Start_Build:IStart
{
   public void Go()
   {
     PersonFatBuilder p = new PersonFatBuilder();
     p.Build();

     PersonThinBuilder p2 = new PersonThinBuilder();
     p2.Build();
   }
}