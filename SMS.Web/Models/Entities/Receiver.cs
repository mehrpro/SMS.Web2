namespace SMS.Web.Models.Entities
{
    public class Receiver
    {
        public int Id { get; set; }

        public int AcademicID_FK { get; set; }
        public AcademicYear AcademicYear { get; set; }

        public int StudentID_FK { get; set; }
        public Student Student { get; set; }

        public int TagID_FK { get; set; }
        public TagCard TagCard { get; set; }

        public bool IsDelete { get; set; }



    }
}
