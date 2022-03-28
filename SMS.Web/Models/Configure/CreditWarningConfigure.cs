using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMS.Web.Models.Entities;

namespace SMS.Web.Models.Configure;

public class CreditWarningConfigure : IEntityTypeConfiguration<CreditWarning>
{
    public void Configure(EntityTypeBuilder<CreditWarning> builder)
    {
        builder.HasKey(x => x.ID);
        builder.Property(x => x.ID).IsRequired().ValueGeneratedOnAdd();
        builder.Property(x => x.Delivery).HasMaxLength(11);
        builder.Property(x => x.ReciverWarning).HasMaxLength(11);
        builder.Property(x => x.SendTime).HasColumnType("datetime");
        builder.Property(x => x.IsDelete).HasDefaultValue(false);


    }
}