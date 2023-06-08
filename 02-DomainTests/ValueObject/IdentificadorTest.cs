using _02_Dominio.ValueObject;
using Xunit;

namespace _02_DomainTests
{
    public class IdentificadorTest
    {
        [Test]
        public void Constructor_CrearIdentificador_GuardaValorCorrectamente()
        {
            // Arrange
            Guid valor = Guid.NewGuid();

            // Act
            Identificador identificador = new Identificador(valor);

            // Assert
            Assert.AreEqual(valor, identificador.Valor());
        }
    }
}