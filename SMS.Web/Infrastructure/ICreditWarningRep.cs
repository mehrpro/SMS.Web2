using Microsoft.EntityFrameworkCore;
using SMS.Web.Models;
using SMS.Web.Models.Entities;

namespace SMS.Web.Infrastructure;

public interface ICreditWarningRep : IRepository<CreditWarning>
{
    
}

public class CreditWarningRep : Repository<CreditWarning>, ICreditWarningRep
{
    public CreditWarningRep(ApplicationDbContext context) : base(context)
    {

    }

    private ApplicationDbContext ApplicationDbContext => Context as ApplicationDbContext;
}
