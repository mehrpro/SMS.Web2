namespace SMS.Web.Models.Entities;

public class BrithDayRegistered
{
    public int ID { get; set; }
    public int ReceiverID_FK { get; set; }
    public Receiver Receiver { get; set; }
    public DateTime SendDate { get; set; }
    public string? Delivery { get; set; }

}