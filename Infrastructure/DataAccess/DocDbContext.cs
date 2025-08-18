using Domain.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataAccess
{
    public class DocDbContext : DbContext
    {
        public DocDbContext(DbContextOptions<DocDbContext> options)
    : base(options) { }

        public DbSet<Document> Documents { get; set; }
    }
}
