using System.Collections.Generic;
using TAB_clinic_Model;

namespace TAB_clinic_Services
{
    public class AdminService
    {
        private readonly WrappedContext db = new();

        public void DeleteOtherUsers() => UserManager.DeleteAllNonAdminUsers(db);

        public void SpawnUsers()
        {
            try
            {
                UserManager.CreateUser(db, "natalia", "cheba", ClinicRole.Registrar, "N", "C");
                UserManager.CreateUser(db, "dr", "augustyn", ClinicRole.Doctor, "D", "A");
                UserManager.CreateUser(db, "jerzy", "bodzenta", ClinicRole.LabManager, "J", "B");
                UserManager.CreateUser(db, "dariusz", "mrozek", ClinicRole.LabWorker, "D", "M");
            }
            catch (UserAlreadyExistsException)
            { }
        }

        public List<UserModel> UserList()
        {
            return UserManager.GetUsers(db);
        }
    }
}
