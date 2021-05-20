using System.Diagnostics;
using TAB_clinic_Model;

namespace TAB_clinic_Services
{
    public class LoginService
    {
        public LoginService()
        {
            try
            {
                // Create admin user if one does not exist
                UserContext.CreateUser(db, "admin", "admin", ClinicRole.Admin, "Administer", "Adminowicz");
                db.SaveChanges();
            }
            catch (UserAlreadyExistsException)
            { }
        }

        private WrappedContext db = new();

        public UserModel? SignIn(string login, string password)
        {
            var user = UserContext.FindUser(db, login);

            if (user is not null && user.CheckPassword(password))
            {
                return user;
            }
            else
            {
                Trace.WriteLine("Signing in failed");
                return null;
            }
        }
    }
}
