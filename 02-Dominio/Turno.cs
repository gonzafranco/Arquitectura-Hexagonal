using System.Text.RegularExpressions;

namespace _02_Dominio
{
    public class Turno
    {
        private string titulo;
        private string descripcion;
        private DateTime fecha;
        private DateTime fechaDeCreacion;
        private string estado;

        public Turno(
             string titulo,
             string descripcion,
             DateTime fecha,
             string estado
        )
        {
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.fechaDeCreacion = DateTime.Now;
            this.estado = estado;
        }


    }
}