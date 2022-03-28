using Microsoft.EntityFrameworkCore;
using SMS.Web.Models;
using SMS.Web.Models.Entities;

namespace SMS.Web.Infrastructure;

public interface IPanelInformationRep : IRepository<PanelInformation>
{
    ValueTask<PanelInformation?> FirstRecorder();
    string[] SendNumber();
    string[] WarningReceiver();
    int MinCredit();
    int MidCredit();
}

public class PanelInformationRep : Repository<PanelInformation>, IPanelInformationRep
{
    public PanelInformationRep(ApplicationDbContext context) : base(context)
    {
    }

    ApplicationDbContext ApplicationDbContext
    {
        get{return Context as ApplicationDbContext;}
    }

    public async ValueTask<PanelInformation?> FirstRecorder()
    {
        return await ApplicationDbContext.PanelInformations.FirstOrDefaultAsync(x=>x.IsActive);
    }

    public string[] SendNumber()
    {
        var result = ApplicationDbContext.PanelInformations.FirstOrDefault();
        return result == null ? new[] { "Error" } : new[] { result.SendNumber };
    }

    public string[] WarningReceiver()
    {
        var result = ApplicationDbContext.PanelInformations.FirstOrDefault();
        return result == null ? new[] { "Error" } : new[] { result.WarningReceiver };
    }

    public int MinCredit()
    {
        var result = ApplicationDbContext.PanelInformations.FirstOrDefault();
        return result == null ? 0 :  result.MinCredit ;
    }

    public int MidCredit()
    {
        var result = ApplicationDbContext.PanelInformations.FirstOrDefault();
        return result == null ? 0 : result.MidCredit;
    }
}