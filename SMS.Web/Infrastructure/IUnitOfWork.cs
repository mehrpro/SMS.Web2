//using ServiceReference1;
using SMS.Web.Models;

namespace SMS.Web.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        IAcademicYearRep AcademicYear { get; }
        IReceiverRep Receiver { get; }
        ISchoolRep School { get; }
        IStudentRep Student { get; }
        ITagCardRep TagCard { get; }
        ITagReciveRep TagRecive { get; }
        ITodayRegisteredRep TodayRegistered { get; }
        //tsmsService TsmsService { get; }
        ICreditWarningRep CreditWarning { get; }
        IPanelInformationRep PanelInformation { get; }
        IBrithDayRegisteredRep BrithDayRegistered { get; }

        Task<int> CommitAsync();
    }


    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IAcademicYearRep _academicYearRep;
        private IReceiverRep _receiver;
        private ITagCardRep _tagCard;
        private IStudentRep _student;
        private ITagReciveRep _tagRecive;
        private ISchoolRep _school;
        private ITodayRegisteredRep _todayRegistered;
        //private tsmsService _tsmsService;
        private ICreditWarningRep _creditWarningRep;
        private IPanelInformationRep _panelInformationRep;
        private IBrithDayRegisteredRep _brithDayRegistered;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IAcademicYearRep AcademicYear => _academicYearRep ??= new AcademicYearRep(_context);
        public IReceiverRep Receiver => _receiver ??= new ReceiverRep(_context);
        public ITagCardRep TagCard => _tagCard ??= new TagCardRep(_context);
        public IStudentRep Student => _student ??= new StudentRep(_context); 
        public ISchoolRep School => _school ??= new SchoolRep(_context);
        public ITagReciveRep TagRecive => _tagRecive ??= new TagReciveRep(_context);
        public ITodayRegisteredRep TodayRegistered => _todayRegistered ??= new TodayRegisteredRep(_context);
        //public tsmsService TsmsService => _tsmsService ??= new tsmsServiceClient();
        public ICreditWarningRep CreditWarning => _creditWarningRep ??= new CreditWarningRep(_context);
        public IPanelInformationRep PanelInformation => _panelInformationRep ??= new PanelInformationRep(_context);
        public IBrithDayRegisteredRep BrithDayRegistered => _brithDayRegistered ??= new BrithDayRegisteredRep(_context);
        public Task<int> CommitAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
