using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Infraestructura
{
    public class LibroRepositorioMemoria: LibroRepositorio
    {
        private List<Libro> libros = new List<Libro>();

        public void grabar(Libro usuario)
        {
           this.libros.Add(usuario);
        }

        public List<Libro> obtenerTodos()
        {
            return this.libros;
        }


        public void modficar(string id)
        {
            throw new NotImplementedException();
        }

        public Libro obtenerPorId(string id)
        {
            throw new NotImplementedException();
        }

        public void borrar(string id)
        {


            throw new NotImplementedException();
        }

    }

    
}
