
using Microsoft.EntityFrameworkCore;
using SMS.Web.Models;
using SMS.Web.Models.Entities;
namespace SMS.Web.Infrastructure
{
    public interface ITagCardRep : IRepository<TagCard>
    {
        Task<bool> FindTagCardByHex(string tagHex);
    }


    public class TagCardRep : Repository<TagCard>, ITagCardRep
    {
        public TagCardRep(ApplicationDbContext context) : base(context)
        {
        }

        public ApplicationDbContext ApplicationDbContext => (ApplicationDbContext)Context;
        public async Task<bool> FindTagCardByHex(string tagHex)
        {
            return await ApplicationDbContext.TagCards.AnyAsync(x => x.TagID_HEX == tagHex);
        }
    }
   
}
