public abstract class Cashsuper
{
    public abstract double acceptCash(double money);    
}


public class CashNormal:Cashsuper
{
      public override double acceptCash(double money)
      {
          return money;
      }
}

public class CashRebate:Cashsuper
{
    private double moneyRebate = 1d;
    public CashRebate(string moneyRebate)
    {
        this.moneyRebate =double.Parse(moneyRebate);
    }
    public override double acceptCash(double money)
    {
        return money*moneyRebate;
    } 
}

public class CashReturn:Cashsuper
{
    private double moneyCondition = 0.0d;
    private double moneyReturn=0.0d;
    public CashReturn(string moneyCondition,string moneyReturn)
    {
        this.moneyReturn = double.Parse(moneyReturn);
        this.moneyCondition = double.Parse(moneyCondition);
    }

    public override double acceptCash(double money)
    {
        double result = money;
        if(money > moneyCondition)
        {
            result = money - Math.Floor(money/moneyCondition)*moneyReturn;
        }
        return result;
    } 
}