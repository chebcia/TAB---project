using System.Diagnostics;
using TAB_clinic_Data.Database;
using static TAB_clinic_Model.ClinicRoleMethods;

namespace TAB_clinic_Model
{
    public class UserModel
    {
        public UserModel(User dbUser)
        {
            this.dbUser = dbUser;
        }

        private readonly User dbUser;

        public string Login
        {
            get => dbUser.Login;
            set => dbUser.Login = value;
        }

        public string Password
        {
            get => dbUser.Password;
            set => dbUser.Password = value;
        }

        public ClinicRole Role
        {
            get => StringToRole(dbUser.Role);
            set => dbUser.Role = value.RoleToString();
        }

        public bool Active
        {
            get => dbUser.Active[0] == ('A');
            set => dbUser.Active = value ? "A" : "N";
        }

        // TODO: proper validation lol
        public bool ValidatePassword(string password)
        {
            if (password == Password)
            {
                return true;
            }

            Trace.WriteLine("Wrong password");  // should frontend know?
            return false;
        }
    }
}
