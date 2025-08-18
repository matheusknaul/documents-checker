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
        Task<Document> GetIdAsync(int id);
        //Task<DateTime> VerifyLastCheck(Document document);

    }
}
