using System;

namespace SMS.Web.Models.Entities
{
    public class AcademicYear
    {
        public AcademicYear()
        {
            Receivers =new HashSet<Receiver>();
        }

        /// <summary>
        /// سال تحصیلی
        /// </summary>
        public int Id { get; set; }
        public string YearTilte { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsDeleted { get; set; }


        public virtual ICollection<Receiver> Receivers { get; set; }



    }
}
