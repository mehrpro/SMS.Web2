using System.ComponentModel.DataAnnotations;

namespace SMS.Web.Models.DTO.AcademicYearDTO;

public class CreateAcademicYearDTO
{
    [Display(Name = "عنوان سال تحصیلی")]
    [Required(ErrorMessage ="وارد کردن {0} الزامی است")]
    [MaxLength(50,ErrorMessage ="نباید از {0} حرف باشد")]
    public string YearTilte { get; set; }
    [Display(Name = "شروع سال تحصیلی")]
    [Required(ErrorMessage = "وارد کردن {0} الزامی است")]
    public DateTime StartTime { get; set; }
    [Display(Name = "پایان سال تحصیلی")]
    [Required(ErrorMessage = "وارد کردن {0} الزامی است")]
    public DateTime EndTime { get; set; }


}