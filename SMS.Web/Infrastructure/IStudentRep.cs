using SMS.Web.Models;
using SMS.Web.Models.Entities;

namespace SMS.Web.Infrastructure
{
    public interface IStudentRep: IRepository<Student>
    {
    }


    public class StudentRep : Repository<Student> , IStudentRep
    {
        public StudentRep(ApplicationDbContext context): base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}
