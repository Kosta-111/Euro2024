﻿// <auto-generated />
using System;
using Euro2024.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Euro2024.Data.Migrations
{
    [DbContext(typeof(Euro2024DbContext))]
    [Migration("20240421002349_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CountryGame", b =>
                {
                    b.Property<int>("CountriesId")
                        .HasColumnType("int");

                    b.Property<int>("GamesId")
                        .HasColumnType("int");

                    b.HasKey("CountriesId", "GamesId");

                    b.HasIndex("GamesId");

                    b.ToTable("CountryGame");
                });

            modelBuilder.Entity("Euro2024.Data.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("HighestStage")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhotoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WinningsCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HighestStage = "Group",
                            Name = "Albania",
                            PhotoLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/36/Flag_of_Albania.svg/700px-Flag_of_Albania.svg.png",
                            WinningsCount = 0
                        },
                        new
                        {
                            Id = 2,
                            HighestStage = "1/8",
                            Name = "Austria",
                            PhotoLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_Austria.svg/800px-Flag_of_Austria.svg.png",
                            WinningsCount = 0
                        },
                        new
                        {
                            Id = 3,
                            HighestStage = "Final",
                            Name = "Belgium",
                            PhotoLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/Flag_of_Belgium.svg/692px-Flag_of_Belgium.svg.png",
                            WinningsCount = 0
                        },
                        new
                        {
                            Id = 4,
                            HighestStage = "1/4",
                            Name = "Croatia",
                            PhotoLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/Flag_of_Croatia.svg/800px-Flag_of_Croatia.svg.png",
                            WinningsCount = 0
                        },
                        new
                        {
                            Id = 5,
                            HighestStage = "Winner",
                            Name = "Czechia",
                            WinningsCount = 1
                        },
                        new
                        {
                            Id = 6,
                            HighestStage = "Winner",
                            Name = "Denmark",
                            WinningsCount = 1
                        },
                        new
                        {
                            Id = 7,
                            HighestStage = "Final",
                            Name = "England",
                            WinningsCount = 0
                        },
                        new
                        {
                            Id = 8,
                            HighestStage = "Winner",
                            Name = "France",
                            WinningsCount = 2
                        },
                        new
                        {
                            Id = 9,
                            HighestStage = "None",
                            Name = "Georgia",
                            WinningsCount = 0
                        },
                        new
                        {
                            Id = 10,
                            HighestStage = "Winner",
                            Name = "Germany",
                            PhotoLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Flag_of_Germany.svg/800px-Flag_of_Germany.svg.png",
                            WinningsCount = 3
                        },
                        new
                        {
                            Id = 11,
                            HighestStage = "1/2",
                            Name = "Hungary",
                            WinningsCount = 0
                        },
                        new
                        {
                            Id = 12,
                            HighestStage = "Winner",
                            Name = "Italy",
                            WinningsCount = 2
                        },
                        new
                        {
                            Id = 13,
                            HighestStage = "Winner",
                            Name = "Netherlands",
                            WinningsCount = 1
                        },
                        new
                        {
                            Id = 14,
                            HighestStage = "1/4",
                            Name = "Poland",
                            WinningsCount = 0
                        },
                        new
                        {
                            Id = 15,
                            HighestStage = "Winner",
                            Name = "Portugal",
                            WinningsCount = 1
                        },
                        new
                        {
                            Id = 16,
                            HighestStage = "1/4",
                            Name = "Romania",
                            WinningsCount = 0
                        },
                        new
                        {
                            Id = 17,
                            HighestStage = "Group",
                            Name = "Scotland",
                            WinningsCount = 0
                        },
                        new
                        {
                            Id = 18,
                            HighestStage = "Final",
                            Name = "Serbia",
                            WinningsCount = 0
                        },
                        new
                        {
                            Id = 19,
                            HighestStage = "Winner",
                            Name = "Slovakia",
                            WinningsCount = 1
                        },
                        new
                        {
                            Id = 20,
                            HighestStage = "Group",
                            Name = "Slovenia",
                            WinningsCount = 0
                        },
                        new
                        {
                            Id = 21,
                            HighestStage = "Winner",
                            Name = "Spain",
                            WinningsCount = 3
                        },
                        new
                        {
                            Id = 22,
                            HighestStage = "1/4",
                            Name = "Switzerland",
                            WinningsCount = 0
                        },
                        new
                        {
                            Id = 23,
                            HighestStage = "1/2",
                            Name = "Türkiye",
                            WinningsCount = 0
                        },
                        new
                        {
                            Id = 24,
                            HighestStage = "1/4",
                            Name = "Ukraine",
                            WinningsCount = 0
                        });
                });

            modelBuilder.Entity("Euro2024.Data.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("StadiumId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("StadiumId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            StadiumId = 1,
                            StartTime = new DateTime(2024, 6, 20, 21, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            StadiumId = 2,
                            StartTime = new DateTime(2024, 6, 21, 21, 40, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            StadiumId = 3,
                            StartTime = new DateTime(2024, 6, 22, 21, 50, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            StadiumId = 4,
                            StartTime = new DateTime(2024, 6, 23, 22, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            StadiumId = 5,
                            StartTime = new DateTime(2024, 6, 24, 22, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Euro2024.Data.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FootballClub")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhotoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TransferValue")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Players");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateOnly(2000, 12, 10),
                            CountryId = 24,
                            FirstName = "Oleg",
                            FootballClub = "Dynamo Kyiv",
                            LastName = "Gusev",
                            PhotoLink = "https://upload.wikimedia.org/wikipedia/commons/c/ca/Oleh_Husyev_20120611.jpg",
                            TransferValue = 1000000
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateOnly(2001, 11, 10),
                            CountryId = 1,
                            FirstName = "Oleg",
                            FootballClub = "Dynamo Kyiv",
                            LastName = "Busin",
                            TransferValue = 1000000
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateOnly(2002, 10, 10),
                            CountryId = 1,
                            FirstName = "Oleg",
                            FootballClub = "Dynamo Kyiv",
                            LastName = "Kusin",
                            TransferValue = 1000000
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateOnly(2003, 9, 10),
                            CountryId = 1,
                            FirstName = "Oleg",
                            FootballClub = "Dynamo Kyiv",
                            LastName = "Tusin",
                            TransferValue = 1000000
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateOnly(2004, 1, 10),
                            CountryId = 1,
                            FirstName = "Oleg",
                            FootballClub = "Dynamo Kyiv",
                            LastName = "Musin",
                            TransferValue = 1000000
                        });
                });

            modelBuilder.Entity("Euro2024.Data.Entities.Stadium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BuildYear")
                        .HasColumnType("int");

                    b.Property<int>("Capacity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhotoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Settlement")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Stadiums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BuildYear = 1936,
                            Capacity = 70033,
                            CountryId = 10,
                            Name = "Olympiastadion",
                            Settlement = "Berlin"
                        },
                        new
                        {
                            Id = 2,
                            BuildYear = 2005,
                            Capacity = 66026,
                            CountryId = 10,
                            Name = "Football Arena Munich",
                            Settlement = "Munich"
                        },
                        new
                        {
                            Id = 3,
                            BuildYear = 1974,
                            Capacity = 61524,
                            CountryId = 10,
                            Name = "BVB Stadion",
                            Settlement = "Dortmund"
                        },
                        new
                        {
                            Id = 4,
                            BuildYear = 1933,
                            Capacity = 50998,
                            CountryId = 10,
                            Name = "Arena Stuttgart",
                            Settlement = "Stuttgart"
                        },
                        new
                        {
                            Id = 5,
                            BuildYear = 2001,
                            Capacity = 49471,
                            CountryId = 10,
                            Name = "Arena AufSchalke",
                            Settlement = "Gelsenkirchen"
                        },
                        new
                        {
                            Id = 6,
                            BuildYear = 2000,
                            Capacity = 50215,
                            CountryId = 10,
                            Name = "Hamburg Arena",
                            Settlement = "Hamburg"
                        },
                        new
                        {
                            Id = 7,
                            BuildYear = 2005,
                            Capacity = 48057,
                            CountryId = 10,
                            Name = "Frankfurt Stadion",
                            Settlement = "Frankfurt"
                        },
                        new
                        {
                            Id = 8,
                            BuildYear = 2004,
                            Capacity = 46264,
                            CountryId = 10,
                            Name = "Dusseldorf Arena",
                            Settlement = "Dusseldorf"
                        },
                        new
                        {
                            Id = 9,
                            BuildYear = 2004,
                            Capacity = 46922,
                            CountryId = 10,
                            Name = "Stadion Koln",
                            Settlement = "Cologne"
                        },
                        new
                        {
                            Id = 10,
                            BuildYear = 2004,
                            Capacity = 46635,
                            CountryId = 10,
                            Name = "RB Arena",
                            Settlement = "Leipzig"
                        });
                });

            modelBuilder.Entity("Euro2024.Data.Entities.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<bool>("IsSold")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GameId = 1,
                            IsSold = false,
                            Place = "A25",
                            Price = 600m
                        },
                        new
                        {
                            Id = 2,
                            GameId = 1,
                            IsSold = false,
                            Place = "B25",
                            Price = 500m
                        },
                        new
                        {
                            Id = 3,
                            GameId = 1,
                            IsSold = false,
                            Place = "C40",
                            Price = 450m
                        },
                        new
                        {
                            Id = 4,
                            GameId = 1,
                            IsSold = false,
                            Place = "D50",
                            Price = 400m
                        },
                        new
                        {
                            Id = 5,
                            GameId = 1,
                            IsSold = false,
                            Place = "D51",
                            Price = 400m
                        });
                });

            modelBuilder.Entity("CountryGame", b =>
                {
                    b.HasOne("Euro2024.Data.Entities.Country", null)
                        .WithMany()
                        .HasForeignKey("CountriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Euro2024.Data.Entities.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Euro2024.Data.Entities.Game", b =>
                {
                    b.HasOne("Euro2024.Data.Entities.Stadium", "Stadium")
                        .WithMany("Games")
                        .HasForeignKey("StadiumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Stadium");
                });

            modelBuilder.Entity("Euro2024.Data.Entities.Player", b =>
                {
                    b.HasOne("Euro2024.Data.Entities.Country", "Country")
                        .WithMany("Players")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Euro2024.Data.Entities.Stadium", b =>
                {
                    b.HasOne("Euro2024.Data.Entities.Country", "Country")
                        .WithMany("Stadiums")
                        .HasForeignKey("CountryId")
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Euro2024.Data.Entities.Ticket", b =>
                {
                    b.HasOne("Euro2024.Data.Entities.Game", "Game")
                        .WithMany("Tickets")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("Euro2024.Data.Entities.Country", b =>
                {
                    b.Navigation("Players");

                    b.Navigation("Stadiums");
                });

            modelBuilder.Entity("Euro2024.Data.Entities.Game", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Euro2024.Data.Entities.Stadium", b =>
                {
                    b.Navigation("Games");
                });
#pragma warning restore 612, 618
        }
    }
}