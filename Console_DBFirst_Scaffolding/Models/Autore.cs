using System;
using System.Collections.Generic;

namespace Console_DBFirst_Scaffolding.Models;

public partial class Autore
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Imagen { get; set; }

    public virtual ICollection<AutoresLibro> AutoresLibros { get; } = new List<AutoresLibro>();
}
