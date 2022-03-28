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
            builder.ApplyConfiguration(new TodayRegisteredConfigure());
            builder.ApplyConfiguration(new CreditWarningConfigure());
            builder.ApplyConfiguration(new PanelInformationConfigure());
            builder.ApplyConfiguration(new BrithDayRegisteredConfigure());
        }

        public virtual DbSet<AcademicYear> AcademicYears { get; set; }
        public virtual DbSet<TagCard> TagCards { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Receiver> Receivers { get; set; }
        public virtual DbSet<tagrecive> tagrecive { get; set; }
        public virtual DbSet<TodayRegistered> TodayRegistereds { get; set; }
        public virtual DbSet<CreditWarning> CreditWarnings { get; set; }
        public virtual DbSet<PanelInformation> PanelInformations { get; set; }
        public virtual DbSet<BrithDayRegistered> BrithDayRegistereds { get; set; }


    }
}
