using Xunit;
using NumerosRomanos;
using FluentAssertions;

namespace NumerosRomanosTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        public void DeberiaDevolverNumeroRomanoCuandoEnvioNumeroArabico(int numeroAConvertir, string resultadoEsperado)
        {
            //Act
            var resulto = Convertidor.ConvertirArabicoARomano(numeroAConvertir);

            //Assert
            resulto.Should().Be(resultadoEsperado);
        }
    }
}