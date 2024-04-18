using System.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Euro2024.Data.Entities;

namespace Euro2024.Data;

public class Euro2024DbContext : DbContext
{
    public Euro2024DbContext() : base()
    {
        //Database.EnsureDeleted();
        //Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        string connStr = ConfigurationManager.ConnectionStrings["EURO_2024"].ConnectionString;
        optionsBuilder.UseSqlServer(connStr);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.Seed();
    }

    public DbSet<Country> Countries { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<Stadium> Stadiums { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
}
