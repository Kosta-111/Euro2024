using Euro2024.Data.Entities;
using PropertyChanged;

namespace Euro2024.App;

[AddINotifyPropertyChangedInterface]
public class PlayerVM
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateOnly BirthDate { get; set; }
    public string? FootballClub { get; set; }
    public int? TransferValue { get; set; }
    public string? PhotoLink { get; set; }
    public string CountryName { get; set; }

    public PlayerVM() { }
    public PlayerVM(Player entity)
    {
        Id = entity.Id;
        Name = $"{entity.FirstName} {entity.LastName}";
        BirthDate = DateOnly.FromDateTime(entity.BirthDate);
        FootballClub = entity.FootballClub;
        TransferValue = entity.TransferValue;
        PhotoLink = entity.PhotoLink;
        CountryName = entity.Country.Name;
    }
}
