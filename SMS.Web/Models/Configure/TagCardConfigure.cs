using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMS.Web.Models.Entities;


namespace SMS.Web.Models.Configure
{
    using Entities;
    public class TagCardConfigure : IEntityTypeConfiguration<TagCard>
    {
        public void Configure(EntityTypeBuilder<TagCard> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x=>x.ID).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.IsUsed).IsRequired();
            builder.Property(x=>x.IsDeleted).IsRequired();
            builder.Property(x => x.TagID_HEX).IsRequired().HasMaxLength(50);
            builder.Property(x => x.CartView).IsRequired().HasMaxLength(50);
            builder.HasMany(x => x.Receivers)
                .WithOne(x => x.TagCard)
                .HasForeignKey(x => x.TagID_FK)
                .OnDelete(DeleteBehavior.NoAction);

            //builder.HasData(
            //    new TagCard { ID = 1, TagID_HEX = "08001F4B90CC", CartView = "0002050960", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 2, TagID_HEX = "08001F4B7A26", CartView = "0002050938", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 3, TagID_HEX = "08001F4B6B37", CartView = "0002050923", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 4, TagID_HEX = "08001F4B6438", CartView = "0002050916", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 5, TagID_HEX = "08001F4B5509", CartView = "0002050901", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 6, TagID_HEX = "07006169737C", CartView = "0006383987", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 7, TagID_HEX = "07006169606F", CartView = "0006383968", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 8, TagID_HEX = "07006168C5CB", CartView = "0006383813", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 9, TagID_HEX = "07006168C8C6", CartView = "0006383816", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 10, TagID_HEX = "070062B70BD9", CartView = "0006469387", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 11, TagID_HEX = "070061B5B96A", CartView = "0006403513", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 12, TagID_HEX = "070062B3C91F", CartView = "0006468553", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 13, TagID_HEX = "060072B40FCF", CartView = "0007517199", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 14, TagID_HEX = "070062B3F026", CartView = "0006468592", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 15, TagID_HEX = "070062B3DF09", CartView = "0006468575", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 16, TagID_HEX = "070062B3DA0C", CartView = "0006468570", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 17, TagID_HEX = "08001F5BBBF7", CartView = "0002055099", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 18, TagID_HEX = "060072B532F3", CartView = "0007517490", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 19, TagID_HEX = "080037DF1EFE", CartView = "0003661598", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 20, TagID_HEX = "080037DF34D4", CartView = "0003661620", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 21, TagID_HEX = "0800379F62C2", CartView = "0003645282", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 22, TagID_HEX = "0800379F59F9", CartView = "0003645273", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 23, TagID_HEX = "0800379F4CEC", CartView = "0003645260", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 24, TagID_HEX = "0800379F43E3", CartView = "0003645251", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 25, TagID_HEX = "080037A0B827", CartView = "0003645624", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 26, TagID_HEX = "080037A0AF30", CartView = "0003645615", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 27, TagID_HEX = "070062B714C6", CartView = "0006469396", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 28, TagID_HEX = "080037DF4AAA", CartView = "0003661642", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 29, TagID_HEX = "070062B31FC9", CartView = "0006468383", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 30, TagID_HEX = "060072B41CDC", CartView = "0007517212", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 31, TagID_HEX = "060072B55190", CartView = "0007517521", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 32, TagID_HEX = "060072B54889", CartView = "0007517512", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 33, TagID_HEX = "08001F5BC884", CartView = "0002055112", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 34, TagID_HEX = "08001F5BA5E9", CartView = "0002055077", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 35, TagID_HEX = "08001F5BB2FE", CartView = "0002055090", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 36, TagID_HEX = "08001F5BD19D", CartView = "0002055121", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 37, TagID_HEX = "080037DF49A9", CartView = "0003661641", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 38, TagID_HEX = "08001F4B81DD", CartView = "0002050945", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 39, TagID_HEX = "080037DF5FBF", CartView = "0003661663", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 40, TagID_HEX = "080037DF7595", CartView = "0003661685", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 41, TagID_HEX = "06006BC51CB4", CartView = "0007062812", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 42, TagID_HEX = "06006BC506AE", CartView = "0007062790", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 43, TagID_HEX = "070061F5C457", CartView = "0006419908", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 44, TagID_HEX = "0700622E4902", CartView = "0006434377", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 45, TagID_HEX = "0700622E763D", CartView = "0006434422", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 46, TagID_HEX = "0700622E6922", CartView = "0006434409", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 47, TagID_HEX = "060072D854F8", CartView = "0007526484", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 48, TagID_HEX = "060072F87EF2", CartView = "0007534718", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 49, TagID_HEX = "060072D857FB", CartView = "0007526487", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 50, TagID_HEX = "060072D8832F", CartView = "0007526531", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 51, TagID_HEX = "08001F4C075C", CartView = "0002051079", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 52, TagID_HEX = "08001E1BC9C4", CartView = "0001973193", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 53, TagID_HEX = "060072E5CB5A", CartView = "0007529931", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 54, TagID_HEX = "060072E5CA5B", CartView = "0007529930", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 55, TagID_HEX = "08001E1BBCB1", CartView = "0001973180", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 56, TagID_HEX = "06006BC4E148", CartView = "0007062753", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 57, TagID_HEX = "06006BC4DA73", CartView = "0007062746", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 58, TagID_HEX = "06006BC23699", CartView = "0007062070", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 59, TagID_HEX = "08001F4C346F", CartView = "0002051124", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 60, TagID_HEX = "08001F4C1D46", CartView = "0002051101", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 61, TagID_HEX = "06006BC4F75E", CartView = "0007062775", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 62, TagID_HEX = "08001F4C3368", CartView = "0002051123", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 63, TagID_HEX = "0700622E7F34", CartView = "0006434431", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 64, TagID_HEX = "0700622E8CC7", CartView = "0006434444", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 65, TagID_HEX = "060072D86DC1", CartView = "0007526509", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 66, TagID_HEX = "080037DF33D3", CartView = "0003661619", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 67, TagID_HEX = "080037A0A23D", CartView = "0003645602", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 68, TagID_HEX = "0700622E5219", CartView = "0006434386", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 69, TagID_HEX = "070062BA954A", CartView = "0006470293", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 70, TagID_HEX = "08001F4C1E45", CartView = "0002051102", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 71, TagID_HEX = "0800379F3696", CartView = "0003645238", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 72, TagID_HEX = "0700622E3C77", CartView = "0006434364", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 73, TagID_HEX = "08001E1BD2DF", CartView = "0001973202", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 74, TagID_HEX = "060072D8963A", CartView = "0007526550", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 75, TagID_HEX = "06006BC50DA5", CartView = "0007062797", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 76, TagID_HEX = "0700622E602B", CartView = "0006434400", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 77, TagID_HEX = "060072E5E170", CartView = "0007529953", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 78, TagID_HEX = "06006BC4F059", CartView = "0007062768", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 79, TagID_HEX = "070061695D52", CartView = "0006383965", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 80, TagID_HEX = "070061F5BF2C", CartView = "0006419903", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 81, TagID_HEX = "08001E029E8A", CartView = "0001966750", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 82, TagID_HEX = "08001F4BF2AE", CartView = "0002051058", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 82, TagID_HEX = "060072E5E071", CartView = "0007529952", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 83, TagID_HEX = "08001F4C0853", CartView = "0002051080", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 84, TagID_HEX = "08001E02998D", CartView = "0001966745", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 85, TagID_HEX = "070061F5DA49", CartView = "0006419930", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 86, TagID_HEX = "070061F5EB78", CartView = "0006419947", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 87, TagID_HEX = "070061F5F063", CartView = "0006419952", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 88, TagID_HEX = "070062BA9649", CartView = "0006470294", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 89, TagID_HEX = "080037C60DF4", CartView = "0003655181", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 90, TagID_HEX = "070061F60696", CartView = "0006419974", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 91, TagID_HEX = "3800DC118376", CartView = "0014422403", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 92, TagID_HEX = "3800DC15A253", CartView = "0014423458", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 93, TagID_HEX = "1F00677BE1E2", CartView = "0006781921", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 94, TagID_HEX = "120060EFCE53", CartView = "0006352846", IsDeleted = false, IsUsed = true },
            //    new TagCard { ID = 95, TagID_HEX = "1F0084F3D6BE", CartView = "0008713174", IsDeleted = false, IsUsed = true }

            //    );

        }
    }
}
