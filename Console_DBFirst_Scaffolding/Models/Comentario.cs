using System;
using System.Collections.Generic;

namespace Console_DBFirst_Scaffolding.Models;

public partial class Comentario
{
    public int Id { get; set; }

    public string? Contenido { get; set; }

    public int LibroId { get; set; }

    public string? UsuarioId { get; set; }

    public virtual Libro Libro { get; set; } = null!;
}
