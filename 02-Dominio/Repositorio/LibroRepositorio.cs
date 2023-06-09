using _02_Dominio.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.Repositorio
{
    public interface LibroRepositorio 
    {
        public List<Libro> obtenerTodos();
        public void grabar(Libro t);

        public Libro obtenerPorId(string id);
        public void modficar(Libro t);
        public void borrar(string id);
    }
}
