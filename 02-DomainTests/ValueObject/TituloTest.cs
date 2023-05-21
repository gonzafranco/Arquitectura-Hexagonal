using _02_Dominio.ValueObject;
using Xunit;

namespace _02_DomainTests
{
    public class TituloTest
    {
        [[Fact]]
        public void Constructor_CrearTitulo_NoNulo_CreaInstancia()
        {
            // Arrange
            string valor = "Titulo para el libro";

            // Act
            Titulo titulo = new Titulo(valor);

            // Assert
            Assert.AreEqual(valor, titulo.Valor());
        }

        [[Fact]]
        public void Constructor_CrearTitulo_Nulo_LanzaExcepcion()
        {
            // Arrange
            string valor = null;

            // Act & Assert
            Assert.Throws<Exception>(() => new Titulo(valor));
        }

        [[Fact]]
        public void Constructor_CrearTitulo_Vacio_LanzaExcepcion()
        {
            // Arrange
            string valor = "";

            // Act & Assert
            Assert.Throws<Exception>(() => new Titulo(valor));
        }

        [[Fact]]
        public void Constructor_CrearTitulo_EspaciosEnBlanco_LanzaExcepcion()
        {
            // Arrange
            string valor = " ";

            // Act & Assert
            Assert.Throws<Exception>(() => new Titulo(valor));
        }
    }
}