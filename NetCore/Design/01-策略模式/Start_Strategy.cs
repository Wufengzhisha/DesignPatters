public class Start_Strategy:IStart
{
    double price = 10.0;
    int number = 10;
    double sumPrice => price *number;

    public void Go()
    {
        Console.WriteLine("Hello 策略！"); 

        //Console.WriteLine(string.Format("总价为{0}",sumPrice));
        
        //打折
    }
}