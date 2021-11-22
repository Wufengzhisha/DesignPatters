public class Resume:ICloneable
{
    private string name = string.Empty;
    private string sex = string.Empty;
    private string age = string.Empty;
    private string timeArea = string.Empty;
    private string company = string.Empty;

    public Resume(string name)
    {
        this.name = name;
    }

    //个人信息
    public void SetPersonalInfo(string sex,string age)
    {
        this.age = age;
        this.sex = sex;
    }
    
    public void SetWorkExperience(string timeArea,string company)
    {
        this.timeArea = timeArea;
        this.company = company;
    }

    public void Display()
    {
        Console.WriteLine("{0} {1} {2}",name,sex,age);
        Console.WriteLine("工作经历：{0} {1}",timeArea,company);
    }

      public   object Clone()
      {
          // 创建当前对象的浅表副本。创建一个新对象，复制非静态字段
          // 值类型---逐位复制
          // 引用类型 --复制引用而不是引用的对象
          return (object)this.MemberwiseClone();
      }

}