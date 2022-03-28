using Microsoft.EntityFrameworkCore;
using SMS.Web.Models;
using SMS.Web.Models.Entities;

namespace SMS.Web.Infrastructure
{
    public interface ITagReciveRep : IRepository<tagrecive>
    {
        Task<List<tagrecive>> GetAllSending();

    }


    public class TagReciveRep : Repository<tagrecive>, ITagReciveRep
    {
        public TagReciveRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext => (ApplicationDbContext)Context;


        public async Task<List<tagrecive>> GetAllSending()
        {
            return await ApplicationDbContext.tagrecive
                .Where(x => x.Delivery == "entry" || x.Delivery == "exit")
                .Include(x => x.Receiver.Student)
                .ToListAsync();
                
        }
    }
    
    
}
