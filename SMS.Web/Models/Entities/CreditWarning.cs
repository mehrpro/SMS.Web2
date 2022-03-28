namespace SMS.Web.Models.Entities;

public class CreditWarning
{
    public int ID { get; set; }
    public string ReciverWarning { get; set; }
    public DateTime SendTime { get; set; }
    public string  Delivery { get; set; }
    public int CreditLevel { get; set; }
    public bool IsDelete { get; set; }



}