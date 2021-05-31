using System.Collections.Generic;
using TAB_clinic_Model;

namespace TAB_clinic_Services
{
    public class AdminService
    {
        private WrappedContext db = new();

        #region not needed, I suppose
        public void DeleteOtherUsers() => UserManager.DeleteAllNonAdminUsers(db);

        public void SpawnUsers()
        {
            try
            {
                UserManager.CreateUser(db, "natalia", "cheba", ClinicRole.Registrar, true, "N", "C");
                UserManager.CreateUser(db, "dr", "augustyn", ClinicRole.Doctor, true, "D", "A");
                UserManager.CreateUser(db, "jerzy", "bodzenta", ClinicRole.LabManager, true, "J", "B");
                UserManager.CreateUser(db, "dariusz", "mrozek", ClinicRole.LabWorker, true, "D", "M");
            }
            catch (UserAlreadyExistsException)
            { }
        }
        #endregion

        public List<UserModel> UserList()
        {
            return UserManager.GetUsers(db);
        }

        private void AbandonChanges()
        {
            db.Dispose();
            db = new();
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }

        public void CreateUser(string login, string password, ClinicRole role, bool active, string name, string lastname)
        {
            try
            {
                UserManager.CreateUser(db, login, password, role, active, name, lastname);
            }
            catch (InvalidUserDataException)
            {
                AbandonChanges();
                throw;
            }
        }
    }
}
