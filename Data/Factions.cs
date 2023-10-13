namespace Factions{


public enum FactionType 
{
    Xeno,
    Chaos,
    Imperial
}

public class Faction
{
    public string ?FactionName {get; set;}

    public FactionType Type {get; set;}

    public Faction(string name, FactionType type)
    {
        FactionName = name;
        Type = type;
    }
}
}