﻿using TAB_clinic_Model;

namespace TAB_clinic_Services
{
    // Each service uses TAB-clinic-Model to provide functionality for the frontend.
    public class LoginService
    {
        public LoginService()
        {
            try
            {
                // Create admin user if one does not exist
                UserManager.CreateUser(db, "admin", "admin", ClinicRole.Admin, true, "Administer", "Adminowicz");
                db.SaveChanges();
            }
            catch (UserAlreadyExistsException)
            { }
        }

        // Every service should have its own database context and pass it to lower-level objects or methods
        private readonly WrappedContext db = new();

        public UserModel SignIn(string login, string password)
        {
            var user = UserManager.FindUser(db, login);

            if (user is null || !user.CheckPassword(password))
            {
                throw new LoginFailedException("Invalid credentials.");
            }
            else    // user not null, password OK
            {
                if (!user.Active)
                {
                    throw new LoginFailedException("User is deactivated.");
                }

                return user!;
            }
        }
    }
}
