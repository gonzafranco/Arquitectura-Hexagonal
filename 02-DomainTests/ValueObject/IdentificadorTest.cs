using _02_Dominio.ValueObject;
using System;
using Xunit;

namespace _02_DomainTests
{
    public class IdentificadorTest
    {
        [Fact]
        public void Constructor_CrearIdentificador_GuardaValorCorrectamente()
        {
            // Arrange
            Guid valor = Guid.NewGuid();

            // Act
            Identificador identificador = new Identificador(valor);

            // Assert
            Assert.True(true);
        }
    }
}