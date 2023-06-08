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

/*

ObtenerLibroPorId obtenedorLibroId = new ObtenerLibroPorId(
    libroRepositorioMongo
    );

Console.WriteLine("Recuperando libro por id...\n");


Libro libroid = obtenedorLibroId.ejecutar("9865d346-3d4e-4d5e-a8e6-db9f232e82c8");
Console.WriteLine(libroid.infoLibro() + "\n");


libroid.cambiarTitulo("El principito");
libroid.cambiarAutor("Antoine de Saint-Exupery");
libroid.cambiarPaginas(120);


ModificarLibro modificadorLibro = new ModificarLibro(
    libroRepositorioMongo
    );




 modificadorLibro.ejecutar(libroid);



*/



/*
BorrarLibro borradorLibroId = new BorrarLibro(
    libroRepositorioMongo
    );

try{
    Console.WriteLine("borrando libro por id...\n");
    borradorLibroId.ejecutar("8732f3c6-befe-43e9-a880-c81af6330e4d");
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
