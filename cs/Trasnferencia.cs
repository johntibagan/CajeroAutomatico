/**
 * @author  John Tibagan
 * @code    1002709915
 */
namespace CajeroAutomatico.cs
{
    class Trasnferencia : FechaEstado
    {
        private double monto;
        private Cliente origen;
        private Cliente destino;
        private Banco banco;

        public Trasnferencia(double monto, Cliente origen, Cliente destino, Banco banco)
        {
            this.monto = monto;
            this.origen = origen;
            this.destino = destino;
            this.banco = banco;
        }

        public double Monto { get => monto; }
        internal Cliente Origen { get => origen; }
        internal Cliente Destino { get => destino; }
        internal Banco Banco { get => banco; }
    }
}
