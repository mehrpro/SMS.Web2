namespace SMS.Web.Models.Configure
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SMS.Web.Models.Entities;
    public class tagreciveConfigure : IEntityTypeConfiguration<tagrecive>
    {
        public void Configure(EntityTypeBuilder<tagrecive> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.TagID).IsRequired().HasMaxLength(45);
            builder.Property(x => x.DateTimeRegister).IsRequired().HasColumnType("timestamp").HasDefaultValueSql("current_timestamp");
            builder.Property(x => x.sending).IsRequired();
            builder.Property(x => x.Delivery).IsRequired();
            builder.Property(x => x.typeReg).IsRequired().HasDefaultValue(true);
            builder.Property(x => x.Dublicate).IsRequired().HasDefaultValue(false);
            builder.Property(x => x.StudentID_FK).IsRequired();
            builder.Property(x => x.TagID_FK).IsRequired();

        }
    }
}
