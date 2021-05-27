using System;

namespace TAB_clinic_Model
{
    public class InvalidUserDataException : Exception
    {
        public InvalidUserDataException(string message) : base(message)
        {
        }
    }
}
