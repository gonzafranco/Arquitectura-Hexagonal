using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using _02_Dominio.ValueObject;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _03_Infraestructura
{
    public class LibroRepositorioPostgres : LibroRepositorio
    {

        private string _connectionString = "Host=localhost;Port=5433;Database=Libros;Username=root;Password=root";

        public void borrar(string id)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Libros WHERE ID = @Id";


                    Guid idGuid = Guid.Parse(id);

                    command.Parameters.AddWithValue("Id", idGuid);

                    var reader = command.ExecuteReader();

                }

            }
            Console.WriteLine("borrado en " + id);
        }

            public void grabar(Libro libro)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Libros (ID, Titulo, Autor,paginas,ISBN) VALUES (@Id, @Titulo, @Autor,@paginas,@ISBN)";
                    command.Parameters.AddWithValue("ID", libro.idLibro());
                    command.Parameters.AddWithValue("Titulo", libro.tituloLibro());
                    command.Parameters.AddWithValue("Autor", libro.autorLibro());
                    command.Parameters.AddWithValue("paginas", libro.paginasLibro());
                    command.Parameters.AddWithValue("ISBN", libro.ISBNLibro());

                    command.ExecuteNonQuery();
                }
            }
        }

        public void modificar(Libro t)
        {
            throw new NotImplementedException();
        }

        public Libro obtenerPorId(string id)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT ID, Titulo, Autor, Paginas, ISBN FROM Libros WHERE ID = @Id";


                    Guid idGuid = Guid.Parse(id);

                    command.Parameters.AddWithValue("ID", idGuid);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Libro(
                                reader.GetGuid(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(4),
                                reader.GetInt32(3)
                            );
                        }
                    }
                }
            }

            return null;

        }


        public List<Libro> obtenerTodos()
        {
            List<Libro> libros = new List<Libro>();

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT ID, Titulo, Autor, Paginas, ISBN FROM Libros";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var libroId = new Identificador(reader.GetGuid(0));

                            var libro = new Libro(reader.GetGuid(0), reader.GetString(1), reader.GetString(2), reader.GetString(4), reader.GetInt32(3));
                            libros.Add(libro);
                        }
                    }
                }
            }

            return libros;
        }
    }
}
    
