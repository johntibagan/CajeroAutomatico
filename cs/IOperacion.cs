namespace CajeroAutomatico.cs
{
    interface IOperacion
    {

        Cliente Autenticar(string usuario, string contrasena);
        double ConsultarSaldo(Cliente cliente);

        double Retirar(Cliente cliente);
    }
}
