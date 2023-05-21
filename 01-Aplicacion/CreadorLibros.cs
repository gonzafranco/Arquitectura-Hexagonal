using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aplicacion
{
    public class CreadorLibros
    {
        private LibroRepositorio repositorio;

        public CreadorLibros(LibroRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void ejecutar(Libro libro)
        {
            this.repositorio.grabar(libro);
        }

    }
}
