using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace SMS.Web.Infrastructure
{
    using Models;
    using Models.Entities;
    public interface IReceiverRep :IRepository<Receiver>
    {
        Task<Receiver?> GetReceiverWithTagCard(string tagHex);
    }

    public class ReceiverRep : Repository<Receiver> , IReceiverRep
    {
        public ReceiverRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }

        public async Task<Receiver?> GetReceiverWithTagCard(string tagHex)
        {
            return await  ApplicationDbContext.Receivers
                .Include(x => x.TagCard)
                .FirstOrDefaultAsync(x=>x.TagCard.TagID_HEX == tagHex && x.TagCard.IsUsed && !x.TagCard.IsDeleted);
        }
    }
}
