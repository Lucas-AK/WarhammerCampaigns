
enum PlanetType
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
    public string PlanetName { get;}
    public bool UnderImperialControl {get;}

    public Planet(string name, string type, string distance, string atmosphere, string temperature, string color)
    {
        Name = name;
        Type = type;
        DistanceFromSun = distance;
        Atmosphere = atmosphere;
        Temperature = temperature;
        Color = color;
    }

}