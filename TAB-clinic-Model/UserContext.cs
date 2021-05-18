using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TAB_clinic_Data.Database;
using static BCrypt.Net.BCrypt;

namespace TAB_clinic_Model
{
    /// <summary>
    /// Deals with finding, creating, and fetching users.
    /// </summary>
    public static class UserContext
    {
        public static UserModel? FindUser(string login)
        {
            using (var context = new ClinicDBContext())
            {
                var user = context.Users
                    .Where(u => u.Login == login)
                    .FirstOrDefault();

                if (user is null)
                    return null;

                return new UserModel(user);
            }
        }

        public static void CreateUser(string login, string plaintextPassword, ClinicRole role)
        {
            if (FindUser(login) != null)
            {
                Trace.WriteLine($"User with login '{login}' already exists");
                throw new UserAlreadyExistsException(login);
            }
            
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(plaintextPassword))
            {
                throw new ArgumentException("You need to provide a login and a password!");
            }

            using (var context = new ClinicDBContext())
            {
                var newUser = new User
                {
                    Login = login,
                    Password = HashPassword(plaintextPassword),
                    Role = role.RoleToString()
                };

                context.Users.Add(newUser);
                context.SaveChanges();

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
            }
        }

        public static List<UserModel> GetUsers()
        {
            using (var context = new ClinicDBContext())
            {
                var users = context.Users.ToList();
                var userList = new List<UserModel>();
                foreach (var u in users)
                {
                    userList.Add(new UserModel(u));
                }
                return userList;
            }
        }

        public static void DeleteAllNonAdminUsers()
        {
            using (var context = new ClinicDBContext())
            {
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
}
