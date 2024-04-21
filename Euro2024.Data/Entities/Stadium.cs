namespace Euro2024.Data.Entities;

public class Stadium : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int BuildYear { get; set; }
    public string Settlement { get; set; }
    public int Capacity { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; set; }
    public ICollection<Game> Games { get; set; } = [];
    public string? PhotoLink { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Settlement} ({Country})";
    }
}
