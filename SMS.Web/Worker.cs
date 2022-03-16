using SMS.Web.Infrastructure;

namespace SMS.Web
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IUnitOfWork unitOfWork;

        public Worker(ILogger<Worker> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            this.unitOfWork = unitOfWork;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                var result = await unitOfWork.TagRecive.FindAllAsync();
                await Task.Delay(3000, stoppingToken);
            }
        }
    }
}
