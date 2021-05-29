using System.Collections.Generic;
using TAB_clinic_Model;

namespace TAB_clinic_Services
{
    public class RegistrarService
    {
        private WrappedContext db = new();
        
        private void AbandonChanges()
        {
            db.Dispose();
            db = new();
        }
        
        public void SaveChanges()
        {
            db.SaveChanges();
        }

        public void CreatePatient(string name, string lastname, string pesel)
        {
            try
            {
                PatientMangager.CreatePatient(db, name,lastname, pesel);
            }
            catch
            {
                AbandonChanges();
                throw;
            }
        }
        
        public List<PatientModel> PatientList()
        {
            return PatientMangager.GetPatients(db);
        }
    }
}