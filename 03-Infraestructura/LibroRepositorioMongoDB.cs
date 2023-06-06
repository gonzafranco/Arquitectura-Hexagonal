using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _03_Infraestructura
{
        public class LibroRepositorioMongoDB : LibroRepositorio
        {
            private  IMongoCollection<BsonDocument> _librosCollection;

            public LibroRepositorioMongoDB()
            {
                var client = new MongoClient("mongodb://localhost:27017");
                var database = client.GetDatabase("Libros");
                _librosCollection = database.GetCollection<BsonDocument>("Libros");
            }


       public void borrar(string t1)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("ID", t1);
            _librosCollection.DeleteOne(filter);
        }


        public void grabar(Libro t)
            {

            var json = @"{
                ""ID"": """ + t.idLibro() + @""",
                ""titulo"": """ + t.tituloLibro() + @""",
                ""autor"": """ + t.autorLibro() + @""",
                ""ISBN"": """ + t.ISBNLibro() + @""",
                ""paginas"": " + t.paginasLibro() + @"
            }";

            var document = BsonDocument.Parse(json);
            _librosCollection.InsertOne(document);

        }

        public void modificar(Libro t)
            {
            /*
                var filter = Builders<Libro>.Filter.Eq("_id", t.idLibro());
                var update = Builders<Libro>.Update
                    .Set("Titulo", t.tituloLibro())
                    .Set("Autor", t.autorLibro())
                    .Set("Paginas", t.paginasLibro())
                    .Set("ISBN", t.ISBNLibro());

                _librosCollection.UpdateOne(filter, update);
            */
            throw new NotImplementedException();
        }
        
      
            public Libro obtenerPorId(string t1)
            {
                var filter = Builders<BsonDocument>.Filter.Eq("ID", t1);
                var document = _librosCollection.Find(filter).FirstOrDefault();

                var id = Guid.Parse(document["ID"].AsString);

                var libro = new Libro(
                    id,
                    document["titulo"].AsString,
                    document["autor"].AsString,
                    document["ISBN"].AsString,
                    document["paginas"].AsInt32
                );

                return libro;
            }

        


        public List<Libro> obtenerTodos()
        {
            var documents = _librosCollection.Find(_ => true).ToList();

            var libros = documents.Select(document =>
            {
                var id = Guid.Parse(document["ID"].AsString);

                var libro = new Libro(
                    id,
                    document["titulo"].AsString,
                    document["autor"].AsString,
                    document["ISBN"].AsString,
                    document["paginas"].AsInt32
                );
                return libro;
            }).ToList();

            return libros;
        }




    }

}
