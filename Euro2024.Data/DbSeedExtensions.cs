using Microsoft.EntityFrameworkCore;
using Euro2024.Data.Entities;

namespace Euro2024.Data;

public static class DbSeedExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>().HasData(new Country[]
        {
            new() { Id = 1, Name = "Ukraine", WinningsCount = 0, HighestStage = "1/4" },
            new() { Id = 2, Name = "England", WinningsCount = 0, HighestStage = "1/8" },
            new() { Id = 3, Name = "Italy", WinningsCount = 3, HighestStage = "Winner" },
            new() { Id = 4, Name = "France", WinningsCount = 1, HighestStage = "Winner" },
            new() { Id = 5, Name = "Spain", WinningsCount = 4, HighestStage = "Winner" },
            new() { Id = 6, Name = "Belgium", WinningsCount = 0, HighestStage = "Final" }
        });

        modelBuilder.Entity<Player>().HasData(new Player[]
        {
            new() { Id = 1, FirstName = "Oleg", LastName = "Gusin", BirthDate = new(2000, 12, 10), FootballClub = "Dynamo Kyiv", TransferValue = 1000000, CountryId = 1 },
            new() { Id = 2, FirstName = "Oleg", LastName = "Busin", BirthDate = new(2001, 11, 10), FootballClub = "Dynamo Kyiv", TransferValue = 1000000, CountryId = 1 },
            new() { Id = 3, FirstName = "Oleg", LastName = "Kusin", BirthDate = new(2002, 10, 10), FootballClub = "Dynamo Kyiv", TransferValue = 1000000, CountryId = 1 },
            new() { Id = 4, FirstName = "Oleg", LastName = "Tusin", BirthDate = new(2003, 9, 10), FootballClub = "Dynamo Kyiv", TransferValue = 1000000, CountryId = 1 },
            new() { Id = 5, FirstName = "Oleg", LastName = "Musin", BirthDate = new(2004, 1, 10), FootballClub = "Dynamo Kyiv", TransferValue = 1000000, CountryId = 1 }
        });

        modelBuilder.Entity<Stadium>().HasData(new Stadium[]
        {
            new() { Id = 1, Name = "San Siro", BuildDate = new(2000, 4, 5), Settlement = "Milan", Capacity = 80000, CountryId = 3 },
            new() { Id = 2, Name = "Velodrom", BuildDate = new(1980, 3, 15), Settlement = "Paris", Capacity = 70000, CountryId = 4 },
            new() { Id = 3, Name = "Camp Nou", BuildDate = new(2001, 4, 5), Settlement = "Barselona", Capacity = 60000, CountryId = 5 },
            new() { Id = 4, Name = "Wembley", BuildDate = new(2003, 4, 5), Settlement = "London", Capacity = 70000, CountryId = 2 },
            new() { Id = 5, Name = "Santiago Bernabeu", BuildDate = new(2004, 4, 5), Settlement = "Madrid", Capacity = 80000, CountryId = 5 }
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