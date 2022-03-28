namespace SMS.Web.Models.Entities;

public class PanelInformation
{
    public int Id { get; set; }
    public string SendNumber { get; set; }
    public string WarningReceiver { get; set; }
    public int MinCredit { get; set; }
    public int MidCredit { get; set; }
    public bool IsActive { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

}