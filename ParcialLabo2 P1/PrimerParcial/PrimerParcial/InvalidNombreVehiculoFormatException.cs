using System;

namespace PrimerParcial
{
    public class InvalidNombreVehiculoFormatException : Exception
    {
        public InvalidNombreVehiculoFormatException() : base(Constants.InvalidNombreErrorMessage)
        {
        }
    }
}