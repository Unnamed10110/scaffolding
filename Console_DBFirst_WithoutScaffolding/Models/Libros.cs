using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_DBFirst_WithoutScaffolding.Models
{
    public  class Libros
    {
        public int Id { get; set; }

        public string? Titulo { get; set; }

        public DateTime? FechaPublicacion { get; set; }
    }
}
