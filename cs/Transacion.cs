
namespace CajeroAutomatico.cs
{
    class Transacion : FechaEstado
    {
        private double monto;
        private Cliente cliente;

        public Transacion(double monto, Cliente cliente) : base()
        {
            this.monto = monto;
            this.cliente = cliente;
        }

        public double Monto { get => monto; }
        internal Cliente Cliente { get => cliente; }
    }
}
