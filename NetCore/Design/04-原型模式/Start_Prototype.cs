public class Start_Prototype:IStart
{
    public void Go()
    {
        Resume a =new Resume("wx");
        a.SetPersonalInfo("男","29");
        a.SetWorkExperience("1998-2000","A公司");

         Resume b = a;
         
         a.SetWorkExperience("1998-2000","B公司");
   

         Resume c = (Resume)a.Clone();
         c.SetWorkExperience("1998-2003","C公司"); 
         
         Resume d = (Resume)a.Clone();
         d.SetWorkExperience("1998-2008","D公司"); 

         a.Display();
         b.Display();
         c.Display();
         d.Display();

    }
}