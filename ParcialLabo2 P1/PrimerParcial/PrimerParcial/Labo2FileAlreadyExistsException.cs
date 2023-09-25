using System;

namespace PrimerParcial
{
    public class Labo2FileAlreadyExistsException : Exception
    {
        public Labo2FileAlreadyExistsException() : base(Constants.FileAlreadyExistsErrorMessage)
        {
        }
    }
}