namespace SMS.Web.Models.Entities
{
    public class tagrecive
    {
        public int ID { get; set; }
        public string TagID { get; set; }
        public DateTime DateTimeRegister { get; set; }
        public bool sending { get; set; }
        public string? Delivery { get; set; }
        public bool? typeReg { get; set; }
        public int? ReciverID_FK { get; set; }
        public Receiver Receiver { get; set; }
        public bool IsDeleted { get; set; }


    }
}
