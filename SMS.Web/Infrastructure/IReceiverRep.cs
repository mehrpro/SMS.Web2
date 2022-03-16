namespace SMS.Web.Infrastructure
{
    using SMS.Web.Models;
    using SMS.Web.Models.Entities;
    public interface IReceiverRep :IRepository<Receiver>
    {
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
    }
}
