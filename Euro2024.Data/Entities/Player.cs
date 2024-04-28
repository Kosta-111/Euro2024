namespace Euro2024.Data.Entities;

public class Player : IEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string? FootballClub { get; set; }
    public int? TransferValue { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; set; }
    public string? PhotoLink { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName} ({Country})";
    }
}
