using Microsoft.AspNetCore.SignalR;

namespace WarhammerCampaigns.Data.Factions
{
    public enum FactionType
    {
        Xeno,
        Chaos,
        Imperial
    }

    public class Faction
    {
        public string FactionName { get; set; }
        public string Description { get; set; }
        public FactionType Type { get; set; }

        public string Image {get; set;}

        public Faction(string name, FactionType type, string description, string image)
        {
            FactionName = name;
            Description = description;
            Type = type;
            Image = image;
        }
    }
}
