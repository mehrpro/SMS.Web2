namespace SMS.Web.Models.Configure
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SMS.Web.Models.Entities;
    public class TagCardConfigure : IEntityTypeConfiguration<TagCard>
    {
        public void Configure(EntityTypeBuilder<TagCard> builder)
        {
            builder.HasKey(x => x.TagID);
            builder.Property(x=>x.TagID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.IsUsed).IsRequired();
            builder.Property(x=>x.IsDeleted).IsRequired();
            builder.Property(x => x.TagID_HEX).IsRequired().HasMaxLength(50);
            builder.Property(x => x.CartView).IsRequired().HasMaxLength(50);
            builder.HasMany(x => x.Receivers)
                .WithOne(x => x.TagCard)
                .HasForeignKey(x => x.TagID_FK)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
