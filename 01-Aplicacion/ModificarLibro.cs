using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aplicacion
{
    public class ModificarLibro
    {
        private LibroRepositorio repositorio;

        public ModificarLibro(LibroRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void ejecutar(Libro libro)
        {
            this.repositorio.modficar(libro);
        }
    }
}
