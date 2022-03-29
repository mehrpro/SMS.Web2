using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SMS.Web.Infrastructure;
using SMS.Web.Models.DTO.AcademicYearDTO;
using SMS.Web.Models.Entities;

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
            var list = new List<IndexAcademicYearDTO>();
            foreach (var item in result)
            {
                list.Add(new IndexAcademicYearDTO
                {
                    Id = item.Id,
                    YearTilte = item.YearTilte,
                    IsDeleted = item.IsDeleted
                });
            }
            //var resultMap = _mapper.Map<IEnumerable<IndexAcademicYearDTO>>(result);
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create([Bind("YearTilte,StartTime,EndTime")] CreateAcademicYearDTO model)
        {
            if (ModelState.IsValid)
            {
                var resultMap = _mapper.Map<AcademicYear>(model);
                await _unitOfWork.AcademicYear.AddAsync(resultMap);
                var resultCreate = await _unitOfWork.CommitAsync();
                if (resultCreate == 1)
                    return RedirectToAction(nameof(Index));
            }
            ModelState.AddModelError("", PublicValues.ErrorSave);
            return View(model);

        }
    }
}
