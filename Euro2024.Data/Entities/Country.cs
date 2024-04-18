namespace Euro2024.Data.Entities;

public class Country : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int WinningsCount { get; set; }
    public string? HighestStage { get; set; }
    public ICollection<Player> Players { get; set; } = [];
    public ICollection<Stadium> Stadiums { get; set; } = [];
    public ICollection<Game> Games { get; set; } = [];
    public string? PhotoLink { get; set; }

    public override string ToString()
    {
        return Name;
    }
}