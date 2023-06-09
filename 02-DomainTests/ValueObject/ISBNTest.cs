using _02_Dominio.ValueObject;
using System;
using Xunit;

namespace _02_DomainTests
{
    public class ISBNTest
    {
        [Fact]
        public void Constructor_ISBNSintaxisValida_CreaInstancia()
        {
            // Arrange
            string valor = "ISBN: 9781234567890";

            // Act
            ISBN isbn = new ISBN(valor);

            // Assert
            Assert.True(true);
        }

        [Fact]
        public void Constructor_ISBNSintaxisInvalida_LanzaExcepcion()
        {
            // Arrange
            string valor = "InvalidoISBN";

            // Act & Assert
            Assert.Throws<Exception>(() => new ISBN(valor));
        }
    }
}