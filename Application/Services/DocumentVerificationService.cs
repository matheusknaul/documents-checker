using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    internal class DocumentVerificationService : IService
    {
        private readonly IAppLogger<DocumentVerificationService> _appLogger;

        private readonly IDocumentRepository _documentRepository;

        public DocumentVerificationService(
            IAppLogger<DocumentVerificationService> appLogger,
            IDocumentRepository documentRepository)
        {
            _appLogger = appLogger;
            _documentRepository = documentRepository;
        }

        public Task<bool> ExecuteAsyn()
        {
            throw new NotImplementedException();
        }
    }
    
    
}
