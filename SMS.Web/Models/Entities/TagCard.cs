namespace SMS.Web.Models.Entities
{
    public class TagCard
    {
        public TagCard()
        {
            Receivers = new HashSet<Receiver>();
        }

        public int ID { get; set; }
        public string TagID_HEX { get; set; }
        public string CartView { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsUsed { get; set; }


        public virtual ICollection<Receiver> Receivers { get; set; }
    }
}
