namespace SMS.Web.Models.Entities
{
    public class School
    {
        /// <summary>
        /// مدرسه
        /// </summary>
        public School()
        {
            Students= new HashSet<Student>();
        }

        public int SchoolID { get; set; }
        public string SchoolTitle { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Student> Students { get; set; }  
    }
}
