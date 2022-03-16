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
