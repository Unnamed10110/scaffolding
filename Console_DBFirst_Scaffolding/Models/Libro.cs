using System;
using System.Collections.Generic;

namespace Console_DBFirst_Scaffolding.Models;

public partial class Libro
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public DateTime? FechaPublicacion { get; set; }

    public virtual ICollection<AutoresLibro> AutoresLibros { get; } = new List<AutoresLibro>();

    public virtual ICollection<Comentario> Comentarios { get; } = new List<Comentario>();
}
