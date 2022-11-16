namespace Calculadora
{
    public class CalculadoraDeImpuestos
    {
        const decimal porcentajeIva = 0.16m;
        //const decimal ish = 0.03m;
        
        /// <summary>
        /// decimal monto reserva
        /// </summary>
        /// <param name="montoReserva"></param>
        /// <returns>porcentaje del monto enviado</returns>
        public decimal ObtenerIVA(decimal montoReserva)
        {
            return porcentajeIva * montoReserva;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="montoReserva"></param>
        /// <param name="porcentaje"></param>
        /// <returns>monto reserva * porcentaje</returns>
        public decimal ObtenerISH(decimal montoReserva, decimal porcentaje)
        {
            return montoReserva * porcentaje;
        }

        public decimal ObtenerTotal(decimal montoReserva, decimal ish, decimal iva)
        {
            return montoReserva + ish + iva;
        }
    }
}