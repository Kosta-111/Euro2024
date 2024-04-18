using Euro2024.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Euro2024.Data.Configurations;

internal class PlayerEntityConfigs : IEntityTypeConfiguration<Player>
{
    public void Configure(EntityTypeBuilder<Player> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.FirstName).IsRequired().HasMaxLength(100);
        builder.Property(x => x.LastName).IsRequired().HasMaxLength(100);
        builder.Property(x => x.BirthDate).IsRequired();
        builder.Property(x => x.FootballClub).IsRequired(false).HasMaxLength(50);
        builder.Property(x => x.TransferValue).IsRequired(false).HasDefaultValue(0);
        builder.Property(x => x.PhotoLink).IsRequired(false);

        builder.HasOne(x => x.Country).WithMany(x => x.Players)
                                        .HasForeignKey(x => x.CountryId);
    }
}
