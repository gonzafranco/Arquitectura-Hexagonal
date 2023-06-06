using _02_Dominio.Entidad;
using _02_Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Aplicacion
{
    public  class ObtenerLibroPorId
    {
        private LibroRepositorio repositorio;

        public ObtenerLibroPorId(LibroRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public Libro ejecutar(string id)
        {
            return this.repositorio.obtenerPorId(id);
        }

    }

}
