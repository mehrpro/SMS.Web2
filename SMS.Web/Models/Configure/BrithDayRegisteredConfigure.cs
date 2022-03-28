using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMS.Web.Models.Entities;

namespace SMS.Web.Models.Configure;

public class BrithDayRegisteredConfigure : IEntityTypeConfiguration<BrithDayRegistered>
{
    public void Configure(EntityTypeBuilder<BrithDayRegistered> builder)
    {
        builder.HasKey(x => x.ID);
        builder.Property(x => x.ID).IsRequired().ValueGeneratedOnAdd();
        builder.Property(x => x.SendDate).HasColumnType("datetime");
    }
}