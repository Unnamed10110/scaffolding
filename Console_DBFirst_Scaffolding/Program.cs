


using Console_DBFirst_Scaffolding.Models;
using System;


var context = new WebApiAutoresContext();

var autores = context.Autores.ToList().OrderBy(x => x.Id);

Console.WriteLine("----------------------------------------------");
Console.WriteLine("Autores");
Console.WriteLine("----------------------------------------------");

foreach (var item in autores)
{
    Console.WriteLine($"{item.Id} \t {item.Nombre} \t\t {item.Imagen}");
}

var libros = context.Libros.ToList().OrderBy(x => x.Id);

Console.WriteLine("----------------------------------------------");
Console.WriteLine("Libros");
Console.WriteLine("----------------------------------------------");

foreach (var item in libros)
{
    Console.WriteLine($"{item.Id} \t {item.Titulo} \t\t {item.FechaPublicacion}");
}

