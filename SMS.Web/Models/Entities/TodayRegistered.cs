namespace SMS.Web.Models.Entities;

public class TodayRegistered
{
    public long Id { get; set; }
    public int ReceiverID_FK { get; set; }
    public Receiver Receiver { get; set; }
    public DateTime? EntryTime { get; set; }
    public DateTime? ExitTime { get; set; }

}