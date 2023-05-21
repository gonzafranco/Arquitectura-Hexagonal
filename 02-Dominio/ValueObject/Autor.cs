using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.ValueObject
{
    public class Autor
    {

        private String valor;

        public Autor(String valor)
        {
            this.DebeContenerMasDe4Caracteres(valor);
            this.valor = valor;
        }
        public String Valor()
        {
            return this.valor;
        }
        private void DebeContenerMasDe4Caracteres(String valor)
        {
            if (valor.Length < 4)
            {
                throw new Exception("El nombre del autor debe contener, al menos, 4 caracteres");
            }
        }


    }
}
