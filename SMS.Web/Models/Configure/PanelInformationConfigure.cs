using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMS.Web.Models.Entities;

namespace SMS.Web.Models.Configure;

public class PanelInformationConfigure : IEntityTypeConfiguration<PanelInformation>
{
    public void Configure(EntityTypeBuilder<PanelInformation> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Property(x => x.SendNumber).IsRequired().HasMaxLength(25);
        builder.Property(x => x.WarningReceiver).IsRequired().HasMaxLength(11);
        builder.Property(x => x.Username).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Password).IsRequired().HasMaxLength(50);

        builder.HasData(new PanelInformation
        {
            Id = 1,
            SendNumber = "30007227001374",
            WarningReceiver = "09186620474",
            MinCredit = 12000,
            MidCredit = 50000,
            IsActive = true,
            Username = "iaubijar",
            Password = "M4228056"
        });
    }
}