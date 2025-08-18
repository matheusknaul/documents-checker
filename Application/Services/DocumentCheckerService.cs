using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Logging;
using Domain.Interfaces;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class DocumentCheckerService : IService
    {
        private readonly ILogger<DocumentCheckerService> _logger;
        private readonly IDocumentRepository _documentRepository;
        private string DocumentName { get; set; }

        public DocumentCheckerService(
            ILogger<DocumentCheckerService> logger,
            IDocumentRepository documentRepository,
            string documentName)
        {
            _logger = logger;
            _documentRepository = documentRepository;
            DocumentName = documentName;
        }

        public Task<bool> ExecuteAsync()
        {
            _logger.LogInformation($"{DocumentName} is being verified!");
        }
    }
    
    
}
