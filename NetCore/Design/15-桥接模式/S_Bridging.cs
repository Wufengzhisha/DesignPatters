public class S_Bridging:IStart
{
    public void Go()
    {
        HandsetBrand ab;

        ab = new HandsetBrandN();

        ab.SetHandsetSoft(new HandsetGame());
        ab.Run();

        ab.SetHandsetSoft(new HandsetAddressList());
        ab.Run();

        ab = new HandsetBrandM();

        ab.SetHandsetSoft(new HandsetGame());
        ab.Run();

        ab.SetHandsetSoft(new HandsetAddressList());
        ab.Run();

    }
}