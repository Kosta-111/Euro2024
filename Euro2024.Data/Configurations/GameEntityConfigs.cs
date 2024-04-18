using Euro2024.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Euro2024.Data.Configurations;

internal class GameEntityConfigs : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.StartTime).IsRequired();

        builder.HasOne(x => x.Stadium).WithMany(x => x.Games)
                                        .HasForeignKey(x => x.StadiumId);
        builder.HasMany(x => x.Countries).WithMany(x => x.Games);
    }
}
