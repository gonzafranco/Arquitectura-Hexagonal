using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.ValueObject
{
    public class Titulo
    {

        private String valor;

        public Titulo(String valor)
        {
            this.NoDebeSerNulo(valor);
            this.valor = valor;
        }
        public String Valor()
        {
            return this.valor;
        }
        private void NoDebeSerNulo(String valor)
        {
            if (String.IsNullOrWhiteSpace(valor))
            {
                throw new Exception("El titulo debe contener, al menos, 1 caracter");
            }
        }

    }
}
