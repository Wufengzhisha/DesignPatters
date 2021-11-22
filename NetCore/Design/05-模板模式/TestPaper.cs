public class TestPaper
{
    public void Question_1()
    {
        Console.WriteLine("这是试题1");
        Console.WriteLine("答案是"+Answer1());
    }
    public void Question_2()
    {
        Console.WriteLine("这是试题2");
        Console.WriteLine("答案是"+Answer2());
    }
    public void Question_3()
    {
        Console.WriteLine("这是试题3");
        Console.WriteLine("答案是"+Answer3());
    }

    protected virtual string Answer1()
    {
        return "";        
    }
    protected virtual string Answer2()
    {
        return "";        
    }
    protected virtual string Answer3()
    {
        return "";        
    }
}
