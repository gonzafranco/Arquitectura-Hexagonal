using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using _03_Infraestructura.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Infraestructura
{
    public class LibroRepositorioPostgres : LibroRepositorio
    {

        private readonly PostgresContext context;

        public LibroRepositorioPostgres(PostgresContext context)
        {
            this.context = context;
        }

        public void borrar(string id)
        {
            throw new NotImplementedException();
        }

        public void grabar(Libro t)
        {
           
                context.Libros.Add(t);
                context.SaveChanges();
            
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
            throw new NotImplementedException();

        }
    }
}