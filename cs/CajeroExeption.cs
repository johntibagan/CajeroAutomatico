using System;

namespace CajeroAutomatico.cs
{
    class CajeroExeption : Exception
    {
        public CajeroExeption(string message) : base(message)
        {
        }
    }
}
