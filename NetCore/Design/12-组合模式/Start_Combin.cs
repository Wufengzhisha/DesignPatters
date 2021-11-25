public class Start_Combin:IStart
{
    public void Go()
    {
        Composite root = new Composite("root");
        root.Add(new Leaf("Leaf A"));
        root.Add(new Leaf("Leaf B"));

        Composite comp = new Composite("Comp X");
        comp.Add(new Leaf("Leaf XA"));
        comp.Add(new Leaf("Leaf XB"));

        root.Add(comp);

        Composite comp2 = new Composite("Comp XY");
        comp2.Add(new Leaf("Leaf XYA"));
        comp2.Add(new Leaf("Leaf XYB"));
        
        comp.Add(comp2);

        root.Add(new Leaf("Leaf C"));
        root.Add(new Leaf("Leaf D"));

        root.Display(1);
    }
}