using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class Entry : BaseDomainModel
    {
        public string? Text { get; set; }
        public DateTime Date { get; set; }
    }
}
