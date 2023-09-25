using System;

namespace PrimerParcial
{
    public class Labo2NoContentOrOnlyWhiteSpaces : Exception
    {
        public Labo2NoContentOrOnlyWhiteSpaces() : base(Constants.Labo2NoContentOrOnlyWhiteSpacesErrorMessage)
        {
        }
    }
}