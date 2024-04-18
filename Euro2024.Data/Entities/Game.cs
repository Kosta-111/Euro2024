namespace Euro2024.Data.Entities;

public class Game : IEntity
{
    public int Id { get; set; }
    public DateTime StartTime { get; set; }
    public int StadiumId { get; set; }
    public Stadium Stadium { get; set; }
    public ICollection<Country> Countries { get; set; } = [];
    public ICollection<Ticket> Tickets { get; set; } = [];

    public override string ToString()
    {
        return $"{Countries.FirstOrDefault()} - {Countries.LastOrDefault()} ({StartTime: dd.MM.yyyy HH:mm})";
    }
}
