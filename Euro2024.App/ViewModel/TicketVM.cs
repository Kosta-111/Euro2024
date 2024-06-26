﻿using Euro2024.Data.Entities;
using PropertyChanged;
using System.Windows.Media;

namespace Euro2024.App;

[AddINotifyPropertyChangedInterface]
public class TicketVM
{
    public int Id { get; set; }
    public string Place { get; set; }
    public decimal Price { get; set; }
    public bool IsSold { get; set; }
    public string? FirstTeam { get; set; }
    public string? SecondTeam { get; set; }
    public string Stadium { get; set; }
    public DateTime StartTime { get; set; }

    public TicketVM() { }
    public TicketVM(Ticket entity)
    {
        Id = entity.Id;
        Place = entity.Place;
        Price = Math.Round(entity.Price, 2);
        IsSold = entity.IsSold;
        FirstTeam = entity.Game.Countries.FirstOrDefault()?.Name;
        SecondTeam = entity.Game.Countries.LastOrDefault()?.Name;
        Stadium = entity.Game.Stadium.Name;
        StartTime = entity.Game.StartTime;
    }
}
