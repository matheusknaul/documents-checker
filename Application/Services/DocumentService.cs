using Domain.Dtos;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class DocumentService
    {
        private readonly IDocumentRepository _documentRepository;

        public DocumentService(IDocumentRepository documentRepository) => _documentRepository = documentRepository;

        public async Task<Document> GetDocumentByIdAsync(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID must be greater than zero.", nameof(id));
            }
            var document = await _documentRepository.GetIdAsync(id);
            if (document == null)
            {
                throw new KeyNotFoundException($"Document with ID {id} not found.");
            }
            return document;

        }
}
