using System.Text.RegularExpressions;

namespace _02_Dominio
{
    public class Turno
    {
        private string titulo;
        private string descripcion;
        private string cuerpo;
        private DateTime fechaDeCreacion;
        private string estado;

        public Turno(
             string titulo,
             string descripcion,
             string cuerpo,
             string estado
        )
        {
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.cuerpo = cuerpo;
            this.fechaDeCreacion = DateTime.Now;
            this.estado = estado;
        }


    }
}