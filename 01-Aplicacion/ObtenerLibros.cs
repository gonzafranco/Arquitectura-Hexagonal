using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aplicacion
{
    public class ObtenerLibros
    {
            private LibroRepositorio repositorio;

            public ObtenerLibros(LibroRepositorio repositorio)
            {
                this.repositorio = repositorio;
            }

            public List<Libro> ejecutar()
            {
                return this.repositorio.obtenerTodos();
            }

        }
    
}
