using SMS.Web.Models;
using SMS.Web.Models.Entities;

namespace SMS.Web.Infrastructure
{
    public interface IAcademicYearRep : IRepository<AcademicYear>
    {
    }


    public class AcademicYearRep : Repository<AcademicYear> , IAcademicYearRep
    {
        public AcademicYearRep(ApplicationDbContext context): base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }


}
