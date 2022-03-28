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
            builder.HasMany(x => x.Tagrecives)
                .WithOne(x => x.Receiver)
                .HasForeignKey(x => x.ReciverID_FK)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.TodayRegistereds)
                .WithOne(x => x.Receiver)
                .HasForeignKey(x => x.ReceiverID_FK)
                .OnDelete(DeleteBehavior.NoAction);


            //builder.HasData(new Receiver()
            //{
            //    Id = 1,
            //    AcademicID_FK = 1,
            //    StudentID_FK = 1,
            //    TagID_FK = 1,
            //    IsDelete = false
            //});
        }
    }
}
