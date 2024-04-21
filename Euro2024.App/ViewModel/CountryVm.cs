using Euro2024.Data.Entities;

namespace Euro2024.App;
public class CountryVm
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int WinningsCount { get; set; }
    public string? HighestStage { get; set; }
    public string? PhotoLink { get; set; }

    public CountryVm() { }
    public CountryVm(Country entity)
    {
        Id = entity.Id;
        Name = entity.Name;
        WinningsCount = entity.WinningsCount;
        HighestStage = entity.HighestStage;
        PhotoLink = entity.PhotoLink;
    }
}
