public class Singleton
{
    private static Singleton? ini;
    private static readonly object syncRoot = new Object();
    private Singleton() { }
    public static Singleton GetSingleton()
    {
        if (ini == null) //先判断实例是否存在，不存在再加锁处理
        {
            lock (syncRoot)
            {
                if (ini == null)
                {
                    ini = new Singleton();
                }
            }
        }

        return ini;
    }

    public void Hello()
    {
        Console.WriteLine("Hello,I am Singleton!");
    }
}