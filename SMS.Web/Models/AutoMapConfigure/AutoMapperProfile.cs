using AutoMapper;
using SMS.Web.Models.DTO.AcademicYearDTO;
using SMS.Web.Models.Entities;

namespace SMS.Web.Models.AutoMapConfigure;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        //CreateMap<IndexAcademicYearDTO, AcademicYear>();
        CreateMap<AcademicYear, IndexAcademicYearDTO>().ReverseMap();
        CreateMap<CreateAcademicYearDTO, AcademicYear>().ReverseMap();

    }
}