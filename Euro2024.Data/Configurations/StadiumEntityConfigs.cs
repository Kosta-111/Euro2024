using Euro2024.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Euro2024.Data.Configurations;

internal class StadiumEntityConfigs : IEntityTypeConfiguration<Stadium>
{
    public void Configure(EntityTypeBuilder<Stadium> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        builder.Property(x => x.BuildYear).IsRequired();
        builder.Property(x => x.Settlement).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Capacity).IsRequired().HasDefaultValue(0);
        builder.Property(x => x.PhotoLink).IsRequired(false);

        builder.HasOne(x => x.Country).WithMany(x => x.Stadiums)
                                        .HasForeignKey(x => x.CountryId).OnDelete(DeleteBehavior.ClientSetNull);
    }
}
