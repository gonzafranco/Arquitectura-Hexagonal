using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.ValueObject
{
    public class Paginas
    {

        private int valor;

        public Paginas(int valor)
        {
            this.DebeTenerMasDe10Paginas(valor);
            this.valor = valor;
        }
        public int Valor()
        {
            return this.valor;
        }
        private void DebeTenerMasDe10Paginas(int valor)
        {
            if (valor < 10 )
            {
                throw new Exception("La cantidad de paginas del libro debe ser mayor a 10");
            }
        }


    }
}
