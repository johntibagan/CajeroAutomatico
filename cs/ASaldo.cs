using System;

namespace CajeroAutomatico.cs
{
    class ASaldo
    {
        private double saldo;

        public ASaldo(double saldo)
        {
            this.saldo = saldo;
        }

        public double Saldo
        {
            get => saldo;
            set
            {
                saldo = value < 0 ? 0 : value;
            }
        }


        public void actualizarSaldo(double monto)
        {
            if (monto < 0 && Math.Abs(monto) > this.Saldo)
                throw new CajeroExeption("El monto supera el saldo actual de la cuenta");

            this.Saldo += monto;
        }
    }
}
