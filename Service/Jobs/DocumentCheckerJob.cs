using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Jobs
{
    internal class DocumentCheckerJob : IJob
    {
        private readonly IAppLogger<DocumentCheckerJob> _appLogger;
        private readonly DocumentVerificationService _documentVerificationService;

        public DocumentCheckerJob(
            IAppLogger<DocumentCheckerJob> appLogger,
            DocumentVerificationService documentVerificationService)
        {
            _appLogger = appLogger;
            _documentVerificationService = documentVerificationService;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            var et = Stopwatch.StartNew();

            if (_appLogger.IsEnabled(LogLevel.Information))
            {
                _appLogger.LogInformation("DocumentCheckerJob started at: {time}", DateTimeOffset.Now);
            }
            try
            {
                var result = await _documentVerificationService.ExecuteAsyn();
                if (result)
                {
                    _appLogger.LogInformation("Document verification completed successfully.");
                }
                else
                {
                    _appLogger.LogWarning("Document verification did not complete successfully.");
                }
            }
            catch (Exception ex)
            {
                _appLogger.LogError(ex, "An error occurred during document verification.");
            }
        }

    }
}
