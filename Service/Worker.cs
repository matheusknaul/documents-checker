using Domain.Interfaces;

namespace Service
{
    /// <summary>
    /// TODO: Implement a worker service that performs background tasks.
    /// </summary>

    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _appLogger;

        public Worker(ILogger<Worker> appLogger)
        {
            _appLogger = appLogger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _appLogger.LogInformation("Executando tarefa...");
        }
    }
}
