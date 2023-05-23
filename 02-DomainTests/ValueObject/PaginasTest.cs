using _02_Dominio.ValueObject;
using System;
using Xunit;

namespace _02_DomainTests
{
    public class PaginasTest
    {
        [Fact]
        public void Constructor_CrearPaginasConMasDe10_CreaInstancia()
        {
            // Arrange
            int valor = 25;

            // Act
            Paginas paginas = new Paginas(valor);

            // Assert
            Assert.AreEqual(valor, paginas.Valor());
        }

        [Fact]
        public void Constructor_CrearPaginasConMenosDe10_LanzaExcepcion()
        {
            // Arrange
            int valor = 9;

            // Act & Assert
            Assert.Throws<Exception>(() => new Paginas(valor));
        }
    }
}