using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_Dominio.ValueObject
{
    public class ISBN
    {

        private String valor;

        public ISBN(String valor)
        {
            this.DebeTenerSintaxisValida(valor);
            this.valor = valor;
        }
        public String Valor()
        {
            return this.valor;
        }
        private void DebeTenerSintaxisValida(String valor)
        {
            string pattern = @"\b(?:ISBN(?:: ?| ))?((?:97[89])?\d{9}[\dx])\b";

           // string pattern = @"^(?:ISBN-13: )?(?:978(?:-?\d){10}|ISBN-10: \d{9}[\dXx])$";


            var regex = new Regex(pattern);

            if (!regex.IsMatch(valor.Replace("-", "")))
            {
                throw new Exception("El ISBN no es válido");
            }


        }
    }
}
