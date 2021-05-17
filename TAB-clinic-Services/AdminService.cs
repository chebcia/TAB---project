using System.Collections.Generic;
using TAB_clinic_Model;

namespace TAB_clinic_Services
{
    public class AdminService
    {
        public static List<UserModel> UserList()
        {
            return UserContext.GetUsers();
        }
    }
}
