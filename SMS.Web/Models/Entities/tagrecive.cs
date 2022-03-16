namespace SMS.Web.Models.Entities
{
    public class tagrecive
    {
        public int ID { get; set; }
        public string TagID { get; set; }
        public DateTime DateTimeRegister { get; set; }
        public bool sending { get; set; }
        public int Delivery { get; set; }
        public bool typeReg { get; set; }
        public int TagID_FK { get; set; }
        public int StudentID_FK { get; set; }
        public bool Dublicate { get; set; }


    }
}
