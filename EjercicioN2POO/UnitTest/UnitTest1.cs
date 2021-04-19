using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void GivenNumberOne_WhenDivisionCero_ThenReturnZero()
        {
            // Arrange
            int numeroUno = 1;
            int esperado = 0;
            int retorno;

            // Act
            retorno = numeroUno.DivisionCero();

            // Assert
            Assert.AreEqual(esperado, retorno);
        }

        [DataRow(10)]
        [DataRow(1)]
        [DataRow(2)]
        [TestMethod]
        public void GivenValidNumberAndZero_WhenDivision_ThenReturnZero(int dividendo)
        {
            // Arrange
            const int divisor = 0;
            const int esperado = 0;

            // Act
            var retorno = dividendo.Division(divisor);

            // Assert
            Assert.AreEqual(esperado, retorno);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Given_WhenLanzarException_ThenExceptionIsThrown()
        {
            // Arrange

            // Act
            Logic.LanzarException();

            // Assert
        }

        [TestMethod]
        public void GivenValidMessage_WhenLanzarExceptionPropia_ThenExceptionIsThrown()
        {
            // Arrange
            string mensaje = "Se lanzo una excepcion, y fue creada por mi!";
            
            try
            {
                // Act
                Logic.LanzarExceptionPropia(mensaje);
                Assert.Fail();

            }
            catch (ExceptionPropia ex)
            {
                // Assert
                Assert.AreEqual($"Maxi Lenzuen: {mensaje}", ex.Message);
            }

        }
    }
}
