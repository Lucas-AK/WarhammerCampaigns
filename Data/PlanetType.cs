namespace PlanetType{
public enum PlanetType
{
    AgriWorld,
    CivilisedWorld,
    DeadWorld,
    HiveWorld,
    FeudalWorld,
    ResearchStation,
    ForgeWorld,
    FeralWorld
}

public class Planet
{
    public string PlanetName { get; set;}
    public string Alignment {get; set;}
    public bool UnderImperialControl {get; set;}

    public string PlanetViewBackgroundColor {get; set;}

    public PlanetType Type {get; set;}
    public int RequisitionPoints {get; set;}

    public Planet(string name, PlanetType type, string alignment, int requsitionPoints, string backgroundColor)
    {
        PlanetName = name;
        Type = type;
        Alignment = alignment;
        RequisitionPoints = requsitionPoints; 
        PlanetViewBackgroundColor = backgroundColor;
    }

}
}