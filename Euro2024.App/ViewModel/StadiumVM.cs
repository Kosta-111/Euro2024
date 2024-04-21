using Euro2024.Data.Entities;

namespace Euro2024.App;
public class StadiumVM
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int BuildYear { get; set; }
    public string Settlement { get; set; }
    public int Capacity { get; set; }
    public string CountryName { get; set; }
    public string? CountryPhotoLink { get; set; }

    public StadiumVM() { }
    public StadiumVM(Stadium entity)
    {
        Id = entity.Id;
        Name = entity.Name;
        BuildYear = entity.BuildYear;
        Settlement = entity.Settlement;
        Capacity = entity.Capacity;
        CountryName = entity.Country.Name;
        CountryPhotoLink = entity.Country.PhotoLink;
    }
}
