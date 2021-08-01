
using System;
using System.Collections.Generic;

namespace CajeroAutomatico.cs
{
    class Cliente : ASaldo
    {
        private int codigo;
        private string usuario;
        private string contrasena;
        private int puntos;
        private List<Transacion> transaciones;
        public Cliente(int codigo, string usuario, string contrasena, double saldo, int puntos) : base(saldo)
        {
            this.codigo = codigo;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.Puntos = puntos;
            this.transaciones = new List<Transacion>();
        }

        public string Usuario { get => usuario; }
        public int Codigo { get => codigo; }
        public int Puntos { get => puntos; set => puntos = value; }

        public bool autenticar(string contrasena)
        {
            return this.contrasena == contrasena;
        }

        public bool Equals(int codigo)
        {
            return Codigo == codigo;
        }

        public void retiro(double monto)
        {
            Transacion t = new Transacion(monto, this);
            this.transaciones.Add(t);
            this.actualizarSaldo(monto);
        }

        public void canjePuntos(int puntos, float valorCanje)
        {
            double valor = puntos / valorCanje;
            Transacion t = new Transacion(valor, this);
            this.transaciones.Add(t);
            this.puntos -= puntos;
            this.actualizarSaldo(valor);
        }

        public double retirosHoy()
        {
            DateTime nowDate = DateTime.Now;
            // set these to today + time from time picker
            DateTime startDate = new DateTime(nowDate.Year, nowDate.Month, nowDate.Day,
                0, 0, 0);
            DateTime endDate = new DateTime(nowDate.Year, nowDate.Month, nowDate.Day,
                23, 59, 59);

            double montoTotal = 0;
            foreach (Transacion t in transaciones)
                if (t.Estado != FechaEstado.E_CANCELADO && t.Monto < 0 && t.Fecha < endDate && t.Fecha > startDate)
                    montoTotal += t.Monto;

            return Math.Abs(montoTotal);
        }


    }
}
