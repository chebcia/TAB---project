using System;

namespace TAB_clinic_Model
{
    public class UserAlreadyExistsException : Exception
    {
        public UserAlreadyExistsException(string login)
            : base ($"User with login '{login}' already exists")
        {
        }
    }
}
