using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Euro2024.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WinningsCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    HighestStage = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PhotoLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    FootballClub = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransferValue = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    PhotoLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stadiums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BuildYear = table.Column<int>(type: "int", nullable: false),
                    Settlement = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    PhotoLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stadiums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stadiums_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StadiumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Stadiums_StadiumId",
                        column: x => x.StadiumId,
                        principalTable: "Stadiums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryGame",
                columns: table => new
                {
                    CountriesId = table.Column<int>(type: "int", nullable: false),
                    GamesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryGame", x => new { x.CountriesId, x.GamesId });
                    table.ForeignKey(
                        name: "FK_CountryGame_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryGame_Games_GamesId",
                        column: x => x.GamesId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Place = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    IsSold = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "HighestStage", "Name", "PhotoLink" },
                values: new object[,]
                {
                    { 1, "Group", "Albania", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/36/Flag_of_Albania.svg/700px-Flag_of_Albania.svg.png" },
                    { 2, "1/8", "Austria", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/41/Flag_of_Austria.svg/800px-Flag_of_Austria.svg.png" },
                    { 3, "Final", "Belgium", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/Flag_of_Belgium.svg/692px-Flag_of_Belgium.svg.png" },
                    { 4, "1/4", "Croatia", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1b/Flag_of_Croatia.svg/800px-Flag_of_Croatia.svg.png" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "HighestStage", "Name", "PhotoLink", "WinningsCount" },
                values: new object[,]
                {
                    { 5, "Winner", "Czechia", null, 1 },
                    { 6, "Winner", "Denmark", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "HighestStage", "Name", "PhotoLink" },
                values: new object[] { 7, "Final", "England", null });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "HighestStage", "Name", "PhotoLink", "WinningsCount" },
                values: new object[] { 8, "Winner", "France", null, 2 });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "HighestStage", "Name", "PhotoLink" },
                values: new object[] { 9, "None", "Georgia", null });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "HighestStage", "Name", "PhotoLink", "WinningsCount" },
                values: new object[] { 10, "Winner", "Germany", "https://upload.wikimedia.org/wikipedia/commons/thumb/b/ba/Flag_of_Germany.svg/800px-Flag_of_Germany.svg.png", 3 });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "HighestStage", "Name", "PhotoLink" },
                values: new object[] { 11, "1/2", "Hungary", null });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "HighestStage", "Name", "PhotoLink", "WinningsCount" },
                values: new object[,]
                {
                    { 12, "Winner", "Italy", null, 2 },
                    { 13, "Winner", "Netherlands", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "HighestStage", "Name", "PhotoLink" },
                values: new object[] { 14, "1/4", "Poland", null });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "HighestStage", "Name", "PhotoLink", "WinningsCount" },
                values: new object[] { 15, "Winner", "Portugal", null, 1 });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "HighestStage", "Name", "PhotoLink" },
                values: new object[,]
                {
                    { 16, "1/4", "Romania", null },
                    { 17, "Group", "Scotland", null },
                    { 18, "Final", "Serbia", null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "HighestStage", "Name", "PhotoLink", "WinningsCount" },
                values: new object[] { 19, "Winner", "Slovakia", null, 1 });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "HighestStage", "Name", "PhotoLink" },
                values: new object[] { 20, "Group", "Slovenia", null });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "HighestStage", "Name", "PhotoLink", "WinningsCount" },
                values: new object[] { 21, "Winner", "Spain", null, 3 });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "HighestStage", "Name", "PhotoLink" },
                values: new object[,]
                {
                    { 22, "1/4", "Switzerland", null },
                    { 23, "1/2", "Türkiye", null },
                    { 24, "1/4", "Ukraine", null }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "BirthDate", "CountryId", "FirstName", "FootballClub", "LastName", "PhotoLink", "TransferValue" },
                values: new object[,]
                {
                    { 1, new DateOnly(2000, 12, 10), 24, "Oleg", "Dynamo Kyiv", "Gusev", "https://upload.wikimedia.org/wikipedia/commons/c/ca/Oleh_Husyev_20120611.jpg", 1000000 },
                    { 2, new DateOnly(2001, 11, 10), 1, "Oleg", "Dynamo Kyiv", "Busin", null, 1000000 },
                    { 3, new DateOnly(2002, 10, 10), 1, "Oleg", "Dynamo Kyiv", "Kusin", null, 1000000 },
                    { 4, new DateOnly(2003, 9, 10), 1, "Oleg", "Dynamo Kyiv", "Tusin", null, 1000000 },
                    { 5, new DateOnly(2004, 1, 10), 1, "Oleg", "Dynamo Kyiv", "Musin", null, 1000000 }
                });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "Id", "BuildYear", "Capacity", "CountryId", "Name", "PhotoLink", "Settlement" },
                values: new object[,]
                {
                    { 1, 1936, 70033, 10, "Olympiastadion", null, "Berlin" },
                    { 2, 2005, 66026, 10, "Football Arena Munich", null, "Munich" },
                    { 3, 1974, 61524, 10, "BVB Stadion", null, "Dortmund" },
                    { 4, 1933, 50998, 10, "Arena Stuttgart", null, "Stuttgart" },
                    { 5, 2001, 49471, 10, "Arena AufSchalke", null, "Gelsenkirchen" },
                    { 6, 2000, 50215, 10, "Hamburg Arena", null, "Hamburg" },
                    { 7, 2005, 48057, 10, "Frankfurt Stadion", null, "Frankfurt" },
                    { 8, 2004, 46264, 10, "Dusseldorf Arena", null, "Dusseldorf" },
                    { 9, 2004, 46922, 10, "Stadion Koln", null, "Cologne" },
                    { 10, 2004, 46635, 10, "RB Arena", null, "Leipzig" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "StadiumId", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 20, 21, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2024, 6, 21, 21, 40, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2024, 6, 22, 21, 50, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, new DateTime(2024, 6, 23, 22, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, new DateTime(2024, 6, 24, 22, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "GameId", "Place", "Price" },
                values: new object[,]
                {
                    { 1, 1, "A25", 600m },
                    { 2, 1, "B25", 500m },
                    { 3, 1, "C40", 450m },
                    { 4, 1, "D50", 400m },
                    { 5, 1, "D51", 400m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CountryGame_GamesId",
                table: "CountryGame",
                column: "GamesId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_StadiumId",
                table: "Games",
                column: "StadiumId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_CountryId",
                table: "Players",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Stadiums_CountryId",
                table: "Stadiums",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_GameId",
                table: "Tickets",
                column: "GameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryGame");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Stadiums");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
