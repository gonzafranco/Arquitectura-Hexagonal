using _01_Aplicacion;
using _02_Dominio;
using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using _02_Dominio.ValueObject;
using _03_Infraestructura;
using System.Text.RegularExpressions;

// ISBN-13 = 9781476793313
// ISBN-13 = 978-1-4767-9331-3 
// ISBN-10 = 0025045407 


Libro libro1 = new Libro(
    Guid.NewGuid(),
    "Jonathan Livingston Seagull",
    "Richard Bach",
    "978-1-4767-9331-3",
    144
    );

Libro libro2 = new Libro(
    Guid.NewGuid(),
    "Jonathan Livingston Seagull",
    "Richard Bach",
    "978-1-4767-9331-3",
    144
    );



Console.WriteLine(libro1.idLibro());

LibroRepositorioMemoria libroRepositorio = new LibroRepositorioMemoria();

CreadorLibros creadorDeLibros = new CreadorLibros(
    libroRepositorio
);

creadorDeLibros.ejecutar(libro1);

ObtenerLibros obtenedorDeLibros = new ObtenerLibros(
    libroRepositorio
);

List<Libro> todosLosLibros = obtenedorDeLibros.ejecutar();

foreach (Libro libro in todosLosLibros)
{
    Console.WriteLine(libro.infoLibro());
}

