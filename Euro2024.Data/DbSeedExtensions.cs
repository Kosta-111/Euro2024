using Microsoft.EntityFrameworkCore;
using Euro2024.Data.Entities;

namespace Euro2024.Data;

public static class DbSeedExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>().HasData(new Country[]
        {
            new() { Id = 1, Name = "Albania", WinningsCount = 0, HighestStage = "Group", PhotoLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/36/Flag_of_Albania.svg/700px-Flag_of_Albania.svg.png" },
            new() { Id = 2, Name = "Austria", WinningsCount = 0, HighestStage = "1/8", PhotoLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_Austria.svg/800px-Flag_of_Austria.svg.png" },
            new() { Id = 3, Name = "Belgium", WinningsCount = 0, HighestStage = "Final", PhotoLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/Flag_of_Belgium.svg/692px-Flag_of_Belgium.svg.png" },
            new() { Id = 4, Name = "Croatia", WinningsCount = 0, HighestStage = "1/4", PhotoLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/Flag_of_Croatia.svg/800px-Flag_of_Croatia.svg.png" },
            new() { Id = 5, Name = "Czechia", WinningsCount = 1, HighestStage = "Winner" },
            new() { Id = 6, Name = "Denmark", WinningsCount = 1, HighestStage = "Winner" },
            new() { Id = 7, Name = "England", WinningsCount = 0, HighestStage = "Final" },
            new() { Id = 8, Name = "France", WinningsCount = 2, HighestStage = "Winner" },
            new() { Id = 9, Name = "Georgia", WinningsCount = 0, HighestStage = "None" },
            new() { Id = 10, Name = "Germany", WinningsCount = 3, HighestStage = "Winner", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Flag_of_Germany.svg/800px-Flag_of_Germany.svg.png" },
            new() { Id = 11, Name = "Hungary", WinningsCount = 0, HighestStage = "1/2" },
            new() { Id = 12, Name = "Italy", WinningsCount = 2, HighestStage = "Winner" },
            new() { Id = 13, Name = "Netherlands", WinningsCount = 1, HighestStage = "Winner" },
            new() { Id = 14, Name = "Poland", WinningsCount = 0, HighestStage = "1/4" },
            new() { Id = 15, Name = "Portugal", WinningsCount = 1, HighestStage = "Winner" },
            new() { Id = 16, Name = "Romania", WinningsCount = 0, HighestStage = "1/4" },
            new() { Id = 17, Name = "Scotland", WinningsCount = 0, HighestStage = "Group" },
            new() { Id = 18, Name = "Serbia", WinningsCount = 0, HighestStage = "Final" },
            new() { Id = 19, Name = "Slovakia", WinningsCount = 1, HighestStage = "Winner" },
            new() { Id = 20, Name = "Slovenia", WinningsCount = 0, HighestStage = "Group" },
            new() { Id = 21, Name = "Spain", WinningsCount = 3, HighestStage = "Winner" },
            new() { Id = 22, Name = "Switzerland", WinningsCount = 0, HighestStage = "1/4" },
            new() { Id = 23, Name = "Türkiye", WinningsCount = 0, HighestStage = "1/2" },
            new() { Id = 24, Name = "Ukraine", WinningsCount = 0, HighestStage = "1/4" }
        });

        modelBuilder.Entity<Player>().HasData(new Player[]
        {
            new() { Id = 1, FirstName = "Oleg", LastName = "Gusev", BirthDate = new(2000, 12, 10), FootballClub = "Dynamo Kyiv", TransferValue = 1000000, CountryId = 24, PhotoLink = "https://upload.wikimedia.org/wikipedia/commons/c/ca/Oleh_Husyev_20120611.jpg" },
            new() { Id = 2, FirstName = "Oleg", LastName = "Busin", BirthDate = new(2001, 11, 10), FootballClub = "Dynamo Kyiv", TransferValue = 1000000, CountryId = 1 },
            new() { Id = 3, FirstName = "Oleg", LastName = "Kusin", BirthDate = new(2002, 10, 10), FootballClub = "Dynamo Kyiv", TransferValue = 1000000, CountryId = 1 },
            new() { Id = 4, FirstName = "Oleg", LastName = "Tusin", BirthDate = new(2003, 9, 10), FootballClub = "Dynamo Kyiv", TransferValue = 1000000, CountryId = 1 },
            new() { Id = 5, FirstName = "Oleg", LastName = "Musin", BirthDate = new(2004, 1, 10), FootballClub = "Dynamo Kyiv", TransferValue = 1000000, CountryId = 1 }
        });

        modelBuilder.Entity<Stadium>().HasData(new Stadium[]
        {
            new() { Id = 1, Name = "Olympiastadion", BuildYear = 1936, Settlement = "Berlin", Capacity = 70033, CountryId = 10 },
            new() { Id = 2, Name = "Football Arena Munich", BuildYear = 2005, Settlement = "Munich", Capacity = 66026, CountryId = 10 },
            new() { Id = 3, Name = "BVB Stadion", BuildYear = 1974, Settlement = "Dortmund", Capacity = 61524, CountryId = 10 },
            new() { Id = 4, Name = "Arena Stuttgart", BuildYear = 1933, Settlement = "Stuttgart", Capacity = 50998, CountryId = 10 },
            new() { Id = 5, Name = "Arena AufSchalke", BuildYear = 2001, Settlement = "Gelsenkirchen", Capacity = 49471, CountryId = 10 },
            new() { Id = 6, Name = "Hamburg Arena", BuildYear = 2000, Settlement = "Hamburg", Capacity = 50215, CountryId = 10 },
            new() { Id = 7, Name = "Frankfurt Stadion", BuildYear = 2005, Settlement = "Frankfurt", Capacity = 48057, CountryId = 10 },
            new() { Id = 8, Name = "Dusseldorf Arena", BuildYear = 2004, Settlement = "Dusseldorf", Capacity = 46264, CountryId = 10 },
            new() { Id = 9, Name = "Stadion Koln", BuildYear = 2004, Settlement = "Cologne", Capacity = 46922, CountryId = 10 },
            new() { Id = 10, Name = "RB Arena", BuildYear = 2004, Settlement = "Leipzig", Capacity = 46635, CountryId = 10 }
        });
        modelBuilder.Entity<Game>().HasData(new Game[]
        {
            new() { Id = 1, StartTime = new(2024, 6, 20, 21, 30, 00), StadiumId = 1 },
            new() { Id = 2, StartTime = new(2024, 6, 21, 21, 40, 00), StadiumId = 2 },
            new() { Id = 3, StartTime = new(2024, 6, 22, 21, 50, 00), StadiumId = 3 },
            new() { Id = 4, StartTime = new(2024, 6, 23, 22, 30, 00), StadiumId = 4 },
            new() { Id = 5, StartTime = new(2024, 6, 24, 22, 00, 00), StadiumId = 5 }
        });

        modelBuilder.Entity<Ticket>().HasData(new Ticket[]
        {
            new() { Id = 1, Place = "A25", Price = 600, GameId = 1 },
            new() { Id = 2, Place = "B25", Price = 500, GameId = 1 },
            new() { Id = 3, Place = "C40", Price = 450, GameId = 1 },
            new() { Id = 4, Place = "D50", Price = 400, GameId = 1 },
            new() { Id = 5, Place = "D51", Price = 400, GameId = 1 }
        });
    }
}