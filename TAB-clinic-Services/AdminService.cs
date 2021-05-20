using System.Collections.Generic;
using TAB_clinic_Model;

namespace TAB_clinic_Services
{
    public class AdminService
    {
        private readonly WrappedContext db = new();

        public void DeleteOtherUsers() => UserContext.DeleteAllNonAdminUsers(db);

        public void SpawnUsers()
        {
            try
            {
                UserContext.CreateUser(db, "natalia", "cheba", ClinicRole.Registrar, "N", "C");
                UserContext.CreateUser(db, "dr", "augustyn", ClinicRole.Doctor, "D", "A");
                UserContext.CreateUser(db, "jerzy", "bodzenta", ClinicRole.LabManager, "J", "B");
                UserContext.CreateUser(db, "dariusz", "mrozek", ClinicRole.LabWorker, "D", "M");
            }
            catch (UserAlreadyExistsException)
            { }
        }

        public List<UserModel> UserList()
        {
            return UserContext.GetUsers(db);
        }
    }
}
