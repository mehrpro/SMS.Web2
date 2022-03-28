using System.ComponentModel.DataAnnotations;

namespace SMS.Web.Models.DTO.AcademicYearDTO;

public class IndexAcademicYearDTO
{
    [Display(Name = "شناسه")]
    public int Id { get; set; }
    [Display(Name ="عنوان سال تحصیلی")]
    public string YearTilte { get; set; }
    [Display(Name = "وضعیت")]
    public bool IsDeleted { get; set; }
}