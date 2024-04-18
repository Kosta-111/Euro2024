using Euro2024.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Euro2024.Data.Configurations;

internal class CountryEntityConfigs : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
        builder.Property(x => x.WinningsCount).IsRequired().HasDefaultValue(0);
        builder.Property(x => x.HighestStage).IsRequired(false).HasMaxLength(20);
        builder.Property(x => x.PhotoLink).IsRequired(false);
    }
}
