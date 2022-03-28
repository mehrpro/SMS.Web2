namespace SMS.Web.Models.Entities
{
    public class Student
    {
        public Student()
        {
            Receivers = new HashSet<Receiver>();
       
        }

        /// <summary>
        /// دانش آموزان
        /// </summary>
        public int StudentID { get; set; }
        public string StudentName { get; set; } 
        public DateTime StudentBirthDate { get; set; }
        public string StudentCode { get; set; }
        public bool IsDeleted { get; set; }
        public long PhoneNumber { get; set; }

        public int SchoolID_FK { get; set; }
        public School School { get; set; }


        public virtual ICollection<Receiver> Receivers { get; set; }




    }
}
