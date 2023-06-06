using _02_Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Dominio.Entidad
{
    public class Libro
    {

        private Identificador ID;
        private Titulo titulo;
        private Autor autor;
        private ISBN ISBN;
        private Paginas paginas;


    
        public Libro(
                Guid    ID,
                string  titulo,
                string  autor,
                string  ISBN,
                int     paginas
            ) 
            {
                this.ID = new Identificador(ID);
                this.titulo = new Titulo(titulo);
                this.autor = new Autor(autor);
                this.ISBN = new ISBN(ISBN);
                this.paginas = new Paginas(paginas);
            }
        
       public Guid idLibro()
        {
            return this.ID.Valor();
        }

        public String tituloLibro() {
            return this.titulo.Valor();
        }

        public String autorLibro()
        {
            return this.autor.Valor();
        }

        public String ISBNLibro()
        {
            return this.ISBN.Valor();
        }

        public int paginasLibro()
        {
            return this.paginas.Valor();
        }


        public String infoLibro()
        {
            return " Titulo: " + this.titulo.Valor() 
                + ",\n Autor: " + this.autor.Valor()
                + ",\n Páginas:  "
                + this.paginas.Valor()
                + "\n ISBN:  "
                + this.ISBN.Valor()
                + "\n("
                + this.ID.Valor()
                + ")";
        }

    }
}
