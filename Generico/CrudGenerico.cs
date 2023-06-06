using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generico
{
    public interface CrudGenerico<T,T1>
    {

        public List<T> obtenerTodos();
        public void grabar(T t);

        public T obtenerPorId(T1 t1);
        public void modificar(T t);
        public void borrar(T1 t1);
    }
}
