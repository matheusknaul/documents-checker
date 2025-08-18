using Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class Document
    {
        public int Id { get; set; }
        public string MainTag { get; set; }
        public string RestTag { get; set; }
        public int Number { get; set; }
        public int PartNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime LastVerification { get; set; }
        public string Version { get; set; }

    }
}
