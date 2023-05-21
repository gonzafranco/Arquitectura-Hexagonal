using _02_Dominio.ValueObject;
using Xunit;

namespace _02_DomainTests
{
    public class EmailTest
    {
        [Fact]
        public void Email_ConEmailValido_InstanciaEmail()
        {
            //Arrange
            string email = "juan@test.com";

            //Act
            Email emailInstanciado = new Email(email);

            //Assert
            Assert.True(true);
        }
    }
}