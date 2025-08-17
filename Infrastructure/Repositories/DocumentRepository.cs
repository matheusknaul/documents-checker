using Domain.Dtos;
using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        public async Task<Document> GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Document> InsertAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Document> UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
