namespace Entidades
{
    public class Movimiento
    {
        public int MovimientoId { get; set; }

        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; } // que va a ser: cargo, compra, consumo, pago o abono.
        public float Monto { get; set; }
        public string Tipo { get; set; } //debito/credito

        public CuentaCorriente Cuenta { get; set; }



    }
}
