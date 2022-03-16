using SMS.Web.Models;
using SMS.Web.Models.Entities;

namespace SMS.Web.Infrastructure
{
    public interface ISchoolRep : IRepository<School>
    {
    }

    public class SchoolRep : Repository<School>, ISchoolRep
    {
        public SchoolRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}
