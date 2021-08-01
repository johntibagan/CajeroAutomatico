
using System;
using System.Collections.Generic;

namespace CajeroAutomatico.cs
{
    class Banco
    {
        private string nombre;
        private List<Cliente> clientes;
        private List<Trasnferencia> tranferencias;
        private double montoMaximoRetiro;
        private float valorCanje;

        public Banco(string nombre, double montoMaximoRetiro)
        {
            this.Nombre = nombre;
            this.montoMaximoRetiro = montoMaximoRetiro;
            this.clientes = new List<Cliente>();
            this.tranferencias = new List<Trasnferencia>();
            this.valorCanje = 10;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public double MontoMaximoRetiro { get => montoMaximoRetiro; }
        internal List<Cliente> Clientes { get => clientes; }

        public float ValorCanje { get => valorCanje; }

        public void addCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public Cliente buscarCuenta(int codigoCliente)
        {
            foreach (Cliente c in this.clientes)
            {
                if (c.Equals(codigoCliente))
                    return c;
            }
            return null;
        }

        public Cliente autenticar(int codigoCliente, string pin)
        {
            Cliente cliente = this.buscarCuenta(codigoCliente);
            if (null != cliente)
                if (cliente.autenticar(pin))
                    return cliente;
            return null;
        }

        internal void transferir(Cliente origen, Cliente destino, double monto)
        {
            origen.actualizarSaldo(-monto);
            destino.actualizarSaldo(monto);
            Trasnferencia trasnferencia = new Trasnferencia(monto, origen, destino, this);
            this.tranferencias.Add(trasnferencia);
        }
    }
}