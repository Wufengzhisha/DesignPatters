

public class Start_Duties
{

    public void Go()
    {
        CommanManger commanManger = new CommanManger("伟华");
        Majordomo majordomo = new Majordomo("小李总");
        GeneraManager generaManager = new GeneraManager("大李总");
        commanManger.SerSuperior(majordomo);
        majordomo.SerSuperior(generaManager);



        Request request = new Request() { RequestType = "请假", Number = 1, RequestContent = "wx请假" };
        Request request2 = new Request() { RequestType = "请假", Number = 4, RequestContent = "wx请假" };
        Request request3 = new Request() { RequestType = "加薪", Number = 500, RequestContent = "wx加薪" };
        Request request4 = new Request() { RequestType = "加薪", Number = 1500, RequestContent = "wx加薪" };

        commanManger.ResquestApplications(request);
        Console.WriteLine("-----------------------------");
        commanManger.ResquestApplications(request2);
        Console.WriteLine("-----------------------------");
        commanManger.ResquestApplications(request3);
        Console.WriteLine("-----------------------------");
        commanManger.ResquestApplications(request4);
        Console.WriteLine("-----------------------------");
    }

}