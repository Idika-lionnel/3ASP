namespace ConsoleApp3;

public class Chien : Animal
{
    public string Race { get; set; }

    public Chien(string nom, int age, string race) : base(nom, age)
    {
        Race = race;
    }

    public override string EmettreSon()
    {
        return "Wouf";
    }

    public override string GetInfos()
    {
        return base.GetInfos() + $", Race: {Race}";
    }
}