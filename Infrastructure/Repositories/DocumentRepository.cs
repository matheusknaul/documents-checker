using Domain.Dtos;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.DataAccess;

namespace Infrastructure.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly DocDbContext _context;

        public DocumentRepository(DocDbContext context)
        {
            _context = context;
        }

        public async Task<Document> GetIdAsync(int id)
        {
            return await _context.Documents.FindAsync(id);
        }

    }
}
