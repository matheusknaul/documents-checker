using Application.Services;
using Quartz;
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
        private readonly ILogger<DocumentCheckerJob> _logger;
        private readonly DocumentCheckerService _documentCheckerService;

        public DocumentCheckerJob(
            ILogger<DocumentCheckerJob> logger,
            DocumentCheckerService documentVerificationService)
        {
            _logger = logger;
            _documentCheckerService = documentVerificationService;
        }

        public async Task Execute(IJobExecutionContext context)
        {
            var et = Stopwatch.StartNew();

            if (_logger.IsEnabled(LogLevel.Information))
            {
                _logger.LogInformation("DocumentCheckerJob started at: {time}", DateTimeOffset.Now);
            }
            try
            {
                var result = await _documentCheckerService.ExecuteAsync();
                if (result)
                {
                    _logger.LogInformation("Document verification completed successfully.");
                }
                else
                {
                    _logger.LogWarning("Document verification did not complete successfully.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred during document verification.");
            }
        }

    }
}
