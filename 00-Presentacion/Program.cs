using _01_Aplicacion;
using _02_Dominio;
using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using _02_Dominio.ValueObject;
using _03_Infraestructura;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using System.Text.RegularExpressions;


// ISBN-13 = 9781476793313
// ISBN-13 = 978-1-4767-9331-3
// ISBN-10 = 0025045407


//id para hacer pruebas a95733a9-bdd2-43b3-bbc0-71f01639c37e

Libro libro1 = new Libro(
            Guid.NewGuid(),
            "Jonathan Livingston Seagull",
            "Richard Bach",
            "978-1-4767-9331-3",
            144
            );


LibroRepositorio libroRepositorio =         new LibroRepositorioMemoria();
LibroRepositorio libroRepositorioPostgres = new LibroRepositorioPostgres();
LibroRepositorio libroRepositorioMongo =    new LibroRepositorioMongoDB();


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

try {
    Libro libroid = obtenedorLibroId.ejecutar("fe7d8cb0-f4ab-4176-a318-029bbcea5b35");
    Console.WriteLine(libroid.infoLibro());
}catch (Exception ex)
{
    Console.WriteLine(ex);
}


BorrarLibro borradorLibroId = new BorrarLibro(
    libroRepositorioMongo
    );

try{
    Console.WriteLine("borrando libro por id...\n");
    borradorLibroId.ejecutar("8d0d991d-2056-440a-a80d-702e19080272");
}
catch(Exception ex)
{
    Console.WriteLine (ex);
}


//"c5bba77b-57f9-4086-8516-7511d58f4351"
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
