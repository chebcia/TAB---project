using System;
using System.Diagnostics;
using System.Linq;
using TAB_clinic_Data.Database;
using static BCrypt.Net.BCrypt;

namespace TAB_clinic_Business
{
    public static class LoginService
    {
        // Creates the admin user if one does not exist.
        static LoginService()
        {
            using (var context = new ClinicDBContext())
            {
                var admin = context.Users
                    .Where(u => u.Login == "admin")
                    .FirstOrDefault();

                if (admin is null)
                {
                    Trace.WriteLine("Admin was not found in the DB - adding now");
                    admin = new User
                    {
                        Login = "admin",
                        Password = "admin",
                        Role = null
                    };

                    context.Users.Add(admin);
                    context.SaveChanges();
                }
                else
                {
                    Trace.WriteLine("Admin was found in the DB");
                }
            }
        }

        public static User SignIn(string login, string password)
        {
            using (var context = new ClinicDBContext())
            {
                var matchingUser = context.Users
                    .Where(u => u.Login == login)
                    .FirstOrDefault();

                if (matchingUser is not null && Verify(password, matchingUser.Password))
                {
                    return matchingUser;
                }
                else
                {
                    return null;
                }
            }
        }

        // TODO : Change roleCode into an enum
        public static void SignUp(string login, string password, string roleCode)
        {
            using (var context = new ClinicDBContext())
            {
                if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                {
                    throw new ArgumentException("You need to provide a login and a password!");
                }

                var userEntry = new User { Login = login, Password = HashPassword(password), Role = roleCode };
                context.Add(userEntry);
                context.SaveChanges();
            }
        }
    }
}
