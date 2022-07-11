public class TallGuy
{
    public string Name;
    public int Height;
    public void TalkAboutYourself()
    {
        Console.WriteLine("Nazywam się " + Name + " i mam " + Height + " centymetrów wzrostu.");
    }
    static void Main(string[] args)
    {
        TallGuy tallGuy = new TallGuy() { Name = "Adam", Height = 189 };
        tallGuy.TalkAboutYourself();
        tallGuy.Honk();
        
    }
    public interface IClown
    {
        string FunnyThingIHave { get;  }
        void Honk();
    }
    public string FunnyThingIHave
    {
        get { return "Duże buty"; }
    }
    public void Honk()
    {
        Console.WriteLine("HOOOONK");
    }
}