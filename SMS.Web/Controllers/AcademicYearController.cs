using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SMS.Web.Infrastructure;
using SMS.Web.Models.DTO.AcademicYearDTO;

namespace SMS.Web.Controllers
{
    public class AcademicYearController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AcademicYearController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _unitOfWork.AcademicYear.GetAllAsync();
            var resultMap = _mapper.Map<IEnumerable<IndexAcademicYearDTO>>(result);
            return View(resultMap);
        }
    }
}
