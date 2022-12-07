using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Console_DBFirst_Scaffolding.Models;

public partial class WebApiAutoresContext : DbContext
{
    public WebApiAutoresContext()
    {
    }

    public WebApiAutoresContext(DbContextOptions<WebApiAutoresContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autore> Autores { get; set; }

    public virtual DbSet<AutoresLibro> AutoresLibros { get; set; }

    public virtual DbSet<Comentario> Comentarios { get; set; }

    public virtual DbSet<Libro> Libros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=WebApiAutores;User Id=postgres;Password=634510");

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autore>(entity =>
        {
            entity.Property(e => e.Nombre).HasMaxLength(200);
        });

        modelBuilder.Entity<AutoresLibro>(entity =>
        {
            entity.HasKey(e => new { e.AutorId, e.LibroId });

            entity.HasIndex(e => e.LibroId, "IX_AutoresLibros_LibroId");

            entity.HasOne(d => d.Autor).WithMany(p => p.AutoresLibros).HasForeignKey(d => d.AutorId);

            entity.HasOne(d => d.Libro).WithMany(p => p.AutoresLibros).HasForeignKey(d => d.LibroId);
        });

        modelBuilder.Entity<Comentario>(entity =>
        {
            entity.HasIndex(e => e.LibroId, "IX_Comentarios_LibroId");

            entity.HasIndex(e => e.UsuarioId, "IX_Comentarios_UsuarioId");

            entity.HasOne(d => d.Libro).WithMany(p => p.Comentarios).HasForeignKey(d => d.LibroId);
        });

        modelBuilder.Entity<Libro>(entity =>
        {
            entity.Property(e => e.Titulo).HasDefaultValueSql("''::text");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
