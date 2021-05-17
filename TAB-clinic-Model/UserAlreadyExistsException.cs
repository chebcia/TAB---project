using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAB_clinic_Model
{
    public class UserAlreadyExistsException : Exception
    {
        public UserAlreadyExistsException()
        {

        }

        public UserAlreadyExistsException(string login)
            : base ($"User with login '{login}' already exists")
        {

        }
    }
}
