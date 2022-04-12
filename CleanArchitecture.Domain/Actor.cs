using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Common
{
    public class Actor : BaseDomainModel
    {
        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public virtual List<Video> Videos { get; set; }

    }
}
