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
            new() { Id = 5, Name = "Czechia", WinningsCount = 1, HighestStage = "Winner", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Flag_of_the_Czech_Republic.svg/800px-Flag_of_the_Czech_Republic.svg.png" },
            new() { Id = 6, Name = "Denmark", WinningsCount = 1, HighestStage = "Winner", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Flag_of_Denmark.svg/512px-Flag_of_Denmark.svg.png" },
            new() { Id = 7, Name = "England", WinningsCount = 0, HighestStage = "Final", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/b/be/Flag_of_England.svg/800px-Flag_of_England.svg.png" },
            new() { Id = 8, Name = "France", WinningsCount = 2, HighestStage = "Winner", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/9/93/Flag_of_France_%281794%E2%80%931815%2C_1830%E2%80%931974%29.svg/800px-Flag_of_France_%281794%E2%80%931815%2C_1830%E2%80%931974%29.svg.png" },
            new() { Id = 9, Name = "Georgia", WinningsCount = 0, HighestStage = "None", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/Flag_of_Georgia.svg/800px-Flag_of_Georgia.svg.png" },
            new() { Id = 10, Name = "Germany", WinningsCount = 3, HighestStage = "Winner", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Flag_of_Germany.svg/800px-Flag_of_Germany.svg.png" },
            new() { Id = 11, Name = "Hungary", WinningsCount = 0, HighestStage = "1/2", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Flag_of_Hungary.svg/800px-Flag_of_Hungary.svg.png" },
            new() { Id = 12, Name = "Italy", WinningsCount = 2, HighestStage = "Winner", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/0/03/Flag_of_Italy.svg/800px-Flag_of_Italy.svg.png" },
            new() { Id = 13, Name = "Netherlands", WinningsCount = 1, HighestStage = "Winner", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Flag_of_the_Netherlands.svg/800px-Flag_of_the_Netherlands.svg.png" },
            new() { Id = 14, Name = "Poland", WinningsCount = 0, HighestStage = "1/4", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/Flag_of_Poland.svg/640px-Flag_of_Poland.svg.png" },
            new() { Id = 15, Name = "Portugal", WinningsCount = 1, HighestStage = "Winner", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Flag_of_Portugal.svg/600px-Flag_of_Portugal.svg.png" },
            new() { Id = 16, Name = "Romania", WinningsCount = 0, HighestStage = "1/4", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Flag_of_Romania.svg/600px-Flag_of_Romania.svg.png" },
            new() { Id = 17, Name = "Scotland", WinningsCount = 0, HighestStage = "Group", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/1/10/Flag_of_Scotland.svg/800px-Flag_of_Scotland.svg.png" },
            new() { Id = 18, Name = "Serbia", WinningsCount = 0, HighestStage = "Final", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/f/ff/Flag_of_Serbia.svg/800px-Flag_of_Serbia.svg.png" },
            new() { Id = 19, Name = "Slovakia", WinningsCount = 1, HighestStage = "Winner", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e6/Flag_of_Slovakia.svg/800px-Flag_of_Slovakia.svg.png" },
            new() { Id = 20, Name = "Slovenia", WinningsCount = 0, HighestStage = "Group", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f0/Flag_of_Slovenia.svg/800px-Flag_of_Slovenia.svg.png" },
            new() { Id = 21, Name = "Spain", WinningsCount = 3, HighestStage = "Winner", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9a/Flag_of_Spain.svg/750px-Flag_of_Spain.svg.png" },
            new() { Id = 22, Name = "Switzerland", WinningsCount = 0, HighestStage = "1/4", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Flag_of_Switzerland.svg/512px-Flag_of_Switzerland.svg.png" },
            new() { Id = 23, Name = "Türkiye", WinningsCount = 0, HighestStage = "1/2", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b4/Flag_of_Turkey.svg/800px-Flag_of_Turkey.svg.png" },
            new() { Id = 24, Name = "Ukraine", WinningsCount = 0, HighestStage = "1/4", PhotoLink= "https://upload.wikimedia.org/wikipedia/commons/thumb/4/49/Flag_of_Ukraine.svg/800px-Flag_of_Ukraine.svg.png" }
        });

        modelBuilder.Entity<Player>().HasData(new Player[]
        {
            new() { Id = 1, FirstName = "Kevin", LastName = "De Bruyne", BirthDate = new(1991, 6, 28), FootballClub = "Manchester City", TransferValue = 90000000, CountryId = 3, PhotoLink = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQpl38EW-M7FK60xwdPYMZWs-wPMAZQJZRGPRPEXGBTmtah-Qx7ymuz0oPa7QM4s41zAkk&usqp=CAU" },
            new() { Id = 2, FirstName = "Andriy", LastName = "Yarmolenko", BirthDate = new(1989, 10, 23), FootballClub = "Dynamo Kyiv", TransferValue = 8000000, CountryId = 24, PhotoLink = "https://novynarnia.com/wp-content/uploads/2022/03/andrij-yarmolenko.jpg" },
            new() { Id = 3, FirstName = "Bernardo", LastName = "Silva", BirthDate = new(1994, 8, 10), FootballClub = "Manchester City", TransferValue = 120000000, CountryId = 15, PhotoLink = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSwxwzQxiU46ENjJwyyScpnO1TYUCazI_TzIatbzb24mrFuR2DAOPXOZtIDUEFD1s-_JrQ&usqp=CAU" },
            new() { Id = 4, FirstName = "Robert", LastName = "Lewandowski", BirthDate = new(1988, 10, 21), FootballClub = "Barselona", TransferValue = 23000000, CountryId = 14, PhotoLink = "https://img.championat.com/news/big/u/m/levandovski-futbolisty-sborn.jpg" },
            new() { Id = 5, FirstName = "Jude", LastName = "Bellingham", BirthDate = new(2003, 6, 29), FootballClub = "Real Madrid", TransferValue = 180000000, CountryId = 7, PhotoLink = "https://img.sportarena.com/2023/08/GettyImages-1610248343-1.jpg" }
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
            new() { Id = 2, Place = "B25", Price = 500, GameId = 2 },
            new() { Id = 3, Place = "C40", Price = 450, GameId = 3 },
            new() { Id = 4, Place = "D50", Price = 400, GameId = 4 },
            new() { Id = 5, Place = "D51", Price = 400, GameId = 5 }
        });
    }
}