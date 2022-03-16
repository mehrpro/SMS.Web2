using SMS.Web.Models;
using SMS.Web.Models.Entities;

namespace SMS.Web.Infrastructure
{
    public interface ITagReciveRep : IRepository<tagrecive>
    {
    }


    public class TagReciveRep : Repository<tagrecive>, ITagReciveRep
    {
        public TagReciveRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
    
    
}
