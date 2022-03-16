
using SMS.Web.Models;
using SMS.Web.Models.Entities;
namespace SMS.Web.Infrastructure
{
    public interface ITagCardRep : IRepository<TagCard>
    {
    }


    public class TagCardRep : Repository<TagCard>, ITagCardRep
    {
        public TagCardRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
   
}
