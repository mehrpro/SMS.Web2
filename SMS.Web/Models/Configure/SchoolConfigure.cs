namespace SMS.Web.Models.Configure
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SMS.Web.Models.Entities;
    public class SchoolConfigure : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder.HasKey(x => x.SchoolID);
            builder.Property(x => x.SchoolID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.SchoolTitle).IsRequired().HasMaxLength(150);
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x=>x.Description).HasMaxLength(200);
            builder.HasMany(x => x.Students)
                .WithOne(x => x.School)
                .HasForeignKey(x => x.SchoolID_FK)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
