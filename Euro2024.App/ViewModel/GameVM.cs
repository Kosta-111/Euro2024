using Euro2024.Data.Entities;
using PropertyChanged;

namespace Euro2024.App;

[AddINotifyPropertyChangedInterface]
public class GameVM
{
    public int Id { get; set; }
    public DateTime StartTime { get; set; }
    public string Stadium { get; set; }
    public string? Team1 { get; set; }
    public string? Team2 { get; set; }
    public string? ImgLink1 { get; set; }
    public string? ImgLink2 { get; set; }

    public GameVM() { }
    public GameVM(Game entity)
    {
        Id = entity.Id;
        StartTime = entity.StartTime;
        Stadium = $"{entity.Stadium.Name} ({entity.Stadium.Settlement})";
        Team1 = entity.Countries.FirstOrDefault()?.Name;
        Team2 = entity.Countries.LastOrDefault()?.Name;
        ImgLink1 = entity.Countries.FirstOrDefault()?.PhotoLink;
        ImgLink2 = entity.Countries.LastOrDefault()?.PhotoLink;
    }
}
