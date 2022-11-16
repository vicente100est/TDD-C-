using Calculadora;

namespace CalculadoraDeImpuestoTest
{
    public class Tests
    {
        /// <summary>
        /// Obtener el IVA a partir del monto de una reserva.
        /// Obtener el impuesto estatal sobre hospedaje a partir del monto de una reserva
        /// Obtener el monto total de la reserva (Con impuestos incluidos)
        ///     Impuestos a considerar:
        ///         IVA = 0.16
        ///         ISH = 0.03
        ///         Reserva = 1550.00
        /// </summary>

        [Test]
        public void ImpuestosTest()
        {
            //The AAA

            //Arrange
            CalculadoraDeImpuestos ci = new CalculadoraDeImpuestos();

            //Act
            decimal iva = ci.ObtenerIVA(1550.00m);

            //Assert
            //IVA = 16%
            //Monto de reserva = 1550.00
            //1550.00 * 0.16 = 248
            Assert.AreEqual(248.00m, iva);
        }

        [Test]
        public void ISHTest()
        {
            //Arrange
            CalculadoraDeImpuestos ci = new CalculadoraDeImpuestos();

            //Act
            decimal ish = ci.ObtenerISH(1550.00m, 0.03m);

            //Assert
            //ish = 3%
            //Monto Reserva = 1550
            //1550.00 * 0.03 = 46.50
            Assert.AreEqual(46.50m, ish);
        }

        [Test]
        public void MontoTotalReservaTest()
        {
            //Arrange
            CalculadoraDeImpuestos ci = new CalculadoraDeImpuestos();

            //Act
            decimal iva = ci.ObtenerIVA(1550.00m);
            decimal ish = ci.ObtenerISH(1550.00m, 0.03m);
            decimal MontoTotal = ci.ObtenerTotal(iva, ish, 1550.00m);

            //Assert
            //Iva = 248
            //ISH = 46.50
            //Monto Reserva = 1550
            //1550.00 + 248 + 46.50 = 1844.50
            Assert.AreEqual(1844.50m, MontoTotal);
        }
    }
}