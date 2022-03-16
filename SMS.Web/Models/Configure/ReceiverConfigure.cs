namespace SMS.Web.Models.Configure
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SMS.Web.Models.Entities;
    public class ReceiverConfigure : IEntityTypeConfiguration<Receiver>
    {
        public void Configure(EntityTypeBuilder<Receiver> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.AcademicID_FK).IsRequired();
            builder.Property(x => x.StudentID_FK).IsRequired();
            builder.Property(x => x.TagID_FK).IsRequired();
        }
    }
}
