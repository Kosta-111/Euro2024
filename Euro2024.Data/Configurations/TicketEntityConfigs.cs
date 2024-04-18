using Euro2024.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Euro2024.Data.Configurations;

internal class TicketEntityConfigs : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Place).IsRequired().HasMaxLength(10);
        builder.Property(x => x.Price).IsRequired().HasColumnType("money");
        builder.Property(x => x.IsSold).IsRequired().HasDefaultValue(false);

        builder.HasOne(x => x.Game).WithMany(x => x.Tickets)
                                        .HasForeignKey(x => x.GameId);
    }
}
