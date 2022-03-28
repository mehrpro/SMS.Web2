using SMS.Web.Models;
using SMS.Web.Models.Entities;

namespace SMS.Web.Infrastructure;

public interface ITodayRegisteredRep : IRepository<TodayRegistered>
{
    
}

public class TodayRegisteredRep : Repository<TodayRegistered>, ITodayRegisteredRep
{
    public TodayRegisteredRep(ApplicationDbContext context) : base(context)
    {

    }

    public ApplicationDbContext ApplicationDbContext => (ApplicationDbContext)Context;
}