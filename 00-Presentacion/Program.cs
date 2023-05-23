using _01_Aplicacion;
using _02_Dominio;
using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using _02_Dominio.ValueObject;
using _03_Infraestructura;
using _03_Infraestructura.Context;
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
    "9781476793313",
    144
    );


Libro libro3 = new Libro(
    Guid.NewGuid(),
    "Jonathan Livingston Seagull",
    "Richard Bach",
    "0025045407",
    144
    );




//Console.WriteLine(libro1.idLibro());


String con = "Host=localhost;Port=5433;Database=Libros;Username=root;Password=root";

LibroRepositorioMemoria libroRepositorio = new LibroRepositorioMemoria();
LibroRepositorioPostgres libroRepositorioPostgres = new LibroRepositorioPostgres(con);


CreadorLibros creadorDeLibros = new CreadorLibros(
    libroRepositorioPostgres
);

creadorDeLibros.ejecutar(libro1);


ObtenerLibros obtenedorDeLibros = new ObtenerLibros(
    libroRepositorioPostgres
);

List<Libro> todosLosLibros = obtenedorDeLibros.ejecutar();

foreach (Libro libro in todosLosLibros)
{
    Console.WriteLine(libro.infoLibro());
}


/*
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
*/
