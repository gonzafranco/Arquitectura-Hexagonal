using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico
{
    public interface CrudGenerico<T>
    {

        public List<T> obtenerTodos();
        public void grabar(T t);

        public T obtenerPorId(string id);
        public void modficar(T t);
        public void borrar(string id);
    }
}
