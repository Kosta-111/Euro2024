namespace Euro2024.Data.Entities;

public class Ticket : IEntity
{
    public int Id { get; set; }
    public string Place { get; set; }
    public decimal Price { get; set; }
    public bool IsSold { get; set; }
    public int GameId { get; set; }
    public Game Game { get; set; }

    public override string ToString()
    {
        return $"{Game} : Place '{Place}' / {Price} EUR)";
    }
}
