

using System;
using System.Windows.Forms;

namespace CajeroAutomatico.cs
{
    class CajeroService
    {

        private static CajeroService instance;
        private Label lblErrors, lblOk;

        private Cliente autenticado;

        private Banco banco;

        internal Cliente Autenticado { get => autenticado; }

        internal Banco Banco { get => banco; }

        private CajeroService()
        {
            this.banco = new Banco("Banco N", 2000000);
            // ---------------- cuenta, nombre, contraseña, efectivo, puntos
            Cliente c1 = new Cliente(10101, "cliente 1", "123", 1500000, 50);
            Cliente c2 = new Cliente(20202, "cliente 2", "123", 3000000, 100);
            Cliente c3 = new Cliente(30303, "cliente 3", "123", 2000000, 30);

            banco.addCliente(c1);
            banco.addCliente(c2);
            banco.addCliente(c3);
        }

        public static CajeroService instanceOf(Label lblErrors, Label lblOk)
        {
            if (null == instance)
                instance = new CajeroService();

            instance.lblErrors = lblErrors;
            instance.lblOk = lblOk;

            return instance;
        }

        #region Operaciones

        public bool autenticar(int codigoCliente, string pin)
        {
            this.resetError();
            this.autenticado = this.banco.autenticar(codigoCliente, pin);
            bool valid = null != Autenticado;
            if (!valid)
                addError("Constraseña o usuario invalido");
            return valid;
        }

        public bool retirar(double monto)
        {
            monto = Math.Abs(monto);
            bool conFondos = monto <= this.autenticado.Saldo;

            if (false == conFondos)
                return addError("Sin recursos suficientes para realziar el retiro");

            double retirosDiarios = autenticado.retirosHoy() + monto;
            if (retirosDiarios > banco.MontoMaximoRetiro)
                return addError("Ha superado el valor máximo de retiros por día de: " + banco.MontoMaximoRetiro);


            autenticado.retiro(-monto);

            return true;
        }

        public bool transferir(int codigoCliente, double monto)
        {
            bool conFondos = monto <= this.autenticado.Saldo;

            if (false == conFondos)
                return addError("Sin recursos suficientes para realziar la transferencia");

            Cliente cuentraATransferir = banco.buscarCuenta(codigoCliente);
            if (null == cuentraATransferir)
                return addError("No existe la cuenta " + codigoCliente + " registrada en el banco " + banco.Nombre);

            if (this.autenticado.Equals(cuentraATransferir))
                return addError("No es posible realizar transferencias a la misma cuenta.");

            banco.transferir(this.autenticado, cuentraATransferir, monto);

            return true;
        }

        public bool canjePuntos(int puntos)
        {
            puntos = Math.Abs(puntos);
            bool conPuntos = puntos <= this.autenticado.Puntos;

            if (false == conPuntos)
                return addError("Puntos maximos a canjear: " + this.autenticado.Puntos);

            autenticado.canjePuntos(puntos, banco.ValorCanje);

            return true;
        }

        #endregion

        #region Errores
        public bool addError(string text)
        {
            lblErrors.Text = text;
            lblErrors.Visible = true;
            return false;
        }

        public void addOk(string text)
        {
            lblOk.Text = text;
            lblOk.Visible = true;
        }

        public void resetError()
        {
            lblErrors.Visible = false;
        }


        public T getNumber<T>(string text) where T : IComparable<T>
        {
            try
            {
                T valor = (T)Convert.ChangeType(text, typeof(T));
                return valor;
            }
            catch (Exception e)
            {
                addError("Error al convertir el valor: " + text + " a número. Error: " + e.Message);
            }

            return default(T);
        }
        #endregion
    }
}
