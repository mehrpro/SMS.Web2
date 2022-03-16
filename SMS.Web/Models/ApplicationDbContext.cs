using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SMS.Web.Models.Configure;
using SMS.Web.Models.Entities;
namespace SMS.Web.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AcademicYearConfigure());
            builder.ApplyConfiguration(new TagCardConfigure());
            builder.ApplyConfiguration(new StudentConfigure());
            builder.ApplyConfiguration(new SchoolConfigure());
            builder.ApplyConfiguration(new ReceiverConfigure());
            builder.ApplyConfiguration(new tagreciveConfigure());

        }

        public virtual DbSet<AcademicYear> AcademicYears { get; set; }
        public virtual DbSet<TagCard> TagCards { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Receiver> Receivers { get; set; }
        public virtual DbSet<tagrecive> tagrecive { get; set; }


    }
}
