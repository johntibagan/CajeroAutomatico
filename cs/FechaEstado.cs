using System;

namespace CajeroAutomatico.cs
{
    class FechaEstado
    {
        public static string E_PEDNIENTE = "P", E_COMPLETADO = "O", E_CANCELADO = "C";

        private DateTime fecha;
        private string estado;

        public FechaEstado()
        {
            this.fecha = DateTime.Now;
            this.estado = E_PEDNIENTE;
        }
        public void completado()
        {
            this.estado = E_COMPLETADO;
        }

        public void cancelar()
        {
            this.estado = E_CANCELADO;
        }

        public DateTime Fecha { get => fecha; }
        public string Estado { get => estado; }
    }
}
