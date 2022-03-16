namespace SMS.Web.Models.Configure
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SMS.Web.Models.Entities;
    public class StudentConfigure : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.StudentID);
            builder.Property(x => x.StudentID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.StudentCode).IsRequired().HasMaxLength(11);
            builder.Property(x => x.StudentBirthDate).IsRequired().HasColumnType("datetime");
            builder.Property(x => x.StudentName).IsRequired().HasMaxLength(150);
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(11);
            builder.HasMany(x => x.Receivers)
                .WithOne(x => x.Student)
                .HasForeignKey(x => x.StudentID_FK)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
