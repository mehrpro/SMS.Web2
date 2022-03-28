using Microsoft.EntityFrameworkCore;
using SMS.Web.Models;
using SMS.Web.Models.Entities;

namespace SMS.Web.Infrastructure;

public interface IBrithDayRegisteredRep : IRepository<BrithDayRegistered>
{
    Task<List<string>?> SendBrithDayList();
    Task<List<BrithDayRegistered>> GetReciverForSendBrith();
}

public class BrithDayRegisteredRep : Repository<BrithDayRegistered>, IBrithDayRegisteredRep
{
    public BrithDayRegisteredRep(ApplicationDbContext context) : base(context)
    {
    }

    private ApplicationDbContext ApplicationDbContext => Context as ApplicationDbContext;

    public async Task<List<string>?> SendBrithDayList()
    {
        var eventB = new List<string>();
        if (DateTime.Now.Hour < Convert.ToInt32(17))
            return eventB;
        var resultReceiver =await ApplicationDbContext.Receivers.Include(x => x.Student).ToListAsync();
        var resultSended = await ApplicationDbContext.BrithDayRegistereds.ToListAsync();
        foreach (var receiver in resultReceiver)
        {
            var toDay = DateTime.Today.AddDays(-1).Date.DayOfYear;
            if (receiver.Student.StudentBirthDate.AddDays(-1).DayOfYear == toDay)
            {
                if (!resultSended.Any(x => x.ReceiverID_FK == receiver.Id && receiver.Student.StudentBirthDate.Date.Month == DateTime.Now.Month &&
                                           receiver.Student.StudentBirthDate.Day == DateTime.Now.Day))
                    try
                    {
                        ApplicationDbContext.BrithDayRegistereds.Add(new BrithDayRegistered
                        {
                            ReceiverID_FK = receiver.Id,
                            SendDate = DateTime.Today.AddDays(-1).Date,
                            Delivery = "Brith"
                        });
                    }
                    catch (Exception e)
                    {
                        eventB.Add("خطا در ثبت اطلاعات در جدول ارسال پیام تولد");
                    }
            }
        }
        return eventB;
    }

    public async Task<List<BrithDayRegistered>> GetReciverForSendBrith()
    {
        return await ApplicationDbContext.BrithDayRegistereds
            .Include(r=>r.Receiver.Student)
            .Where(x=>x.Delivery == "Brith")
            .ToListAsync();
    }
}