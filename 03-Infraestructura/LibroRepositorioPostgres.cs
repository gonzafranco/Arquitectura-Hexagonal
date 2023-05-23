﻿using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using _02_Dominio.ValueObject;
using _03_Infraestructura.Context;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Infraestructura
{
    public class LibroRepositorioPostgres : LibroRepositorio
    {

        private readonly string _connectionString;

        public LibroRepositorioPostgres(string _connectionString)
        {
            this._connectionString = _connectionString;
        }

        public void borrar(string id)
        {
            throw new NotImplementedException();
        }

        public void grabar(Libro libro)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Libros (Id, Titulo, Autor,paginas,ISBN) VALUES (@Id, @Titulo, @Autor,@paginas,@ISBN)";
                    command.Parameters.AddWithValue("Id", libro.idLibro());
                    command.Parameters.AddWithValue("Titulo", libro.tituloLibro());
                    command.Parameters.AddWithValue("Autor", libro.autorLibro());
                    command.Parameters.AddWithValue("paginas", libro.paginasLibro());
                    command.Parameters.AddWithValue("ISBN", libro.ISBNLibro());

                    command.ExecuteNonQuery();
                }
            }
        }



        public void modficar(string id)
        {
            throw new NotImplementedException();
        }

        public Libro obtenerPorId(string id)
        {
            throw new NotImplementedException();
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
                    command.CommandText = "SELECT Id, Titulo, Autor, Paginas, ISBN FROM Libros";

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