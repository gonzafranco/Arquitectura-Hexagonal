using _02_Dominio.ValueObject;
using System;
using Xunit;

namespace _02_DomainTests
{
    public class AutorTest
    {
        [Fact]
        public void Constructor_AutorConMenosDe4Caracteres_LanzaExcepcion()
        {
            // Arrange
            string valor = "Ana";

            // Act & Assert
            Assert.Throws<Exception>(() => new Autor(valor));
        }

        [Fact]
        public void Constructor_AutorConMasDe4Caracteres_CreaInstancia()
        {
            // Arrange
            string valor = "Franco";

            // Act
            Autor autor = new Autor(valor);

            // Assert
            Assert.True(true);
        }
    }
  
}