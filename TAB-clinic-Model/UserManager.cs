using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TAB_clinic_Data.Database;

namespace TAB_clinic_Model
{
    /// <summary>
    /// Deals with finding, creating, and fetching users.
    /// </summary>
    public static class UserManager
    {
        public static UserModel? FindUser(WrappedContext db, string login)
        {
            var user = db.Context.Users
                    .Where(u => u.Login == login)
                    .FirstOrDefault();

            if (user is null)
                return null;

            return new UserModel(user);

        }

        /// <summary>
        /// Gets the doctor together with his visit from a UserModel
        /// </summary>
        /// <param name="db"></param>
        /// <param name="model"></param>
        /// <returns>The corresponding Doctor entity or null</returns>
        public static Doctor UserToDoctor(WrappedContext db, UserModel model)   // TODO: this should belong to UserModel
        {
            var doctor = db.Context.Doctors
                .Where(u => u.IdUser == model.IdUser)
                .FirstOrDefault();

            return doctor!;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="login"></param>
        /// <param name="plaintextPassword"></param>
        /// <param name="role"></param>
        /// <param name="active"></param>
        /// <param name="name"></param>
        /// <param name="lastname"></param>
        /// <exception cref="UserAlreadyExistsException"></exception>
        /// <exception cref="InvalidUserDataException"></exception>
        public static void CreateUser(WrappedContext db, string login, string plaintextPassword, ClinicRole role, bool active, string name, string lastname)
        {
            if (FindUser(db, login) != null)
            {
                Trace.WriteLine($"User with login '{login}' already exists");
                throw new UserAlreadyExistsException(login);
            }

            var context = db.Context;

            var newUser = new UserModel(db)
            {
                Login = login,
                Password = plaintextPassword,
                Role = role,
                Active = active,
                Name = name,
                LastName = lastname
            };

            // The new user is only added to the DB after all its fields have been set, using the SaveChanges() method.
            context.SaveChanges();

            // After calling SaveChanges(), the user now has an ID that can be used to create an entry in the correct table.
            switch (role)
            {
                case ClinicRole.Registrar:
                    var registrar = new Registrar() { IdUser = newUser.IdUser };
                    context.Registrars.Add(registrar);
                    break;
                case ClinicRole.Doctor:
                    var doctor = new Doctor() { IdUser = newUser.IdUser };
                    context.Doctors.Add(doctor);
                    break;
                case ClinicRole.LabWorker:
                    var LabWorker = new LabWorker() { IdUser = newUser.IdUser };
                    context.LabWorkers.Add(LabWorker);
                    break;
                case ClinicRole.LabManager:
                    var LabManager = new LabManager() { IdUser = newUser.IdUser };
                    context.LabManagers.Add(LabManager);
                    break;
            }
            context.SaveChanges();
            // The objects above are not wrapped in "Model" classes (UserModel), so they have to be manually added to the right collection in the context.
        }

        public static List<UserModel> GetUsers(WrappedContext db)
        {
            // Wrapping all User objects into UserModel objects.
            var users = db.Context.Users.ToList();
            var userList = new List<UserModel>();
            foreach (var u in users)
            {
                userList.Add(new UserModel(u));
            }
            return userList;
        }

        public static void DeleteAllNonAdminUsers(WrappedContext db)
        {
            var context = db.Context;
            context.RemoveRange(context.Registrars);
            context.RemoveRange(context.Doctors);
            context.RemoveRange(context.LabWorkers);
            context.RemoveRange(context.LabManagers);

            // all users but the admin
            context.RemoveRange(context.Users.Where(u => string.IsNullOrEmpty(u.Role) == false));
            context.SaveChanges();
        }
    }
}
