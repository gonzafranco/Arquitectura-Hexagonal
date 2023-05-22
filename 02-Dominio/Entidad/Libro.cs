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

        private Identificador id;
        private Titulo titulo;
        private Autor autor;
        private ISBN ISBN;
        private Paginas paginas;


    
        public Libro(
                Guid    id,
                string  titulo,
                string  autor,
                string  ISBN,
                int     paginas
            ) 
            {
                this.id = new Identificador(id);
                this.titulo = new Titulo(titulo);
                this.autor = new Autor(autor);
                this.ISBN = new ISBN(ISBN);
                this.paginas = new Paginas(paginas);
            }
        
       public String idLibro()
        {
            return this.id.Valor().ToString();
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
                + this.id.Valor()
                + ")";
        }

    }
}
