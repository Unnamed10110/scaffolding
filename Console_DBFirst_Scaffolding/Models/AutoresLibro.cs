using System;
using System.Collections.Generic;

namespace Console_DBFirst_Scaffolding.Models;

public partial class AutoresLibro
{
    public int LibroId { get; set; }

    public int AutorId { get; set; }

    public int Orden { get; set; }

    public virtual Autore Autor { get; set; } = null!;

    public virtual Libro Libro { get; set; } = null!;
}
