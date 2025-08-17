using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IDocumentRepository
    {
        Task<Document> GetAsync();
        Task<Document> InsertAsync();
        Task<Document> UpdateAsync();


    }
}
