using _01_Aplicacion;
using _02_Dominio;
using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using _02_Dominio.ValueObject;
using _03_Infraestructura;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using System.Text.RegularExpressions;


Libro libro1 = new Libro(
            Guid.NewGuid(),
            "Jonathan Livingston Seagull",
            "Richard Bach",
            "978-1-4767-9331-3",
            144
            );


LibroRepositorio libroRepositorio =         new LibroRepositorioMemoria();
LibroRepositorio libroRepositorioPostgres = new LibroRepositorioPostgres();
LibroRepositorio libroRepositorioMongo =    new LibroRepositorioMongo();



CreadorLibros creadorDeLibros = new CreadorLibros(
    libroRepositorioMongo
);
Console.WriteLine("Guardando libro...\n");
creadorDeLibros.ejecutar(libro1);




ObtenerLibros obtenedorDeLibros = new ObtenerLibros(
    libroRepositorioMongo
);
List<Libro> todosLosLibros = obtenedorDeLibros.ejecutar();

Console.WriteLine("Recuperando libros...\n");
foreach (Libro libro in todosLosLibros)
{
   Console.WriteLine(libro.infoLibro() + "\n");
    
}




ObtenerLibroPorId obtenedorLibroId = new ObtenerLibroPorId(
    libroRepositorioMongo
    );
Console.WriteLine("Recuperando libro por id...\n");

Libro libroid = obtenedorLibroId.ejecutar("b03c5d10-2f20-4064-b185-6b6b8440afab");
Console.WriteLine(libroid.infoLibro() + "\n");


libroid.cambiarTitulo("El principito");
libroid.cambiarAutor("Antoine de Saint-Exupery");
libroid.cambiarPaginas(120);


ModificarLibro modificadorLibro = new ModificarLibro(
    libroRepositorioMongo
    );
 modificadorLibro.ejecutar(libroid);



BorrarLibro borradorLibroId = new BorrarLibro(
    libroRepositorioMongo
    );

Console.WriteLine("borrando libro por id...\n");
borradorLibroId.ejecutar("5ff6a668-3d26-4c83-991a-08321da5afb9");


