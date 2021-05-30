using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;
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
                PatientMangager.CreatePatient(db, name, lastname, pesel);
            }
            catch
            {
                AbandonChanges();
                throw;
            }
        }

        public void UpdatePatient(int patientId, string name, string lastname, string pesel)
        {
            try
            {
                PatientMangager.UpdatePatient(db, patientId, name, lastname, pesel);
            }
            catch
            {
                AbandonChanges();
                throw;
            }
        }

        public void CreateNewVisit(
                int id_doctor, 
                int id_patient, 
                int id_registrar, 
                VisitStatus status,
                string diagnosis, 
                DateTime dt_registered, 
                DateTime? dt_finalized_cancelled, 
                string? description
            )
        {
            try
            {
                VisitManager.CreateVisit(
                    db, 
                    id_doctor, 
                    id_patient, 
                    id_registrar, 
                    status, 
                    diagnosis, 
                    dt_registered,
                    dt_finalized_cancelled,
                    description
                    );
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

        public List<UserModel> DoctorList()
        {
            var userModelData = UserManager.GetUsers(db);
            var filtered = new List<UserModel>();
            
            foreach (var userModelSingle in userModelData)
            {
                if (userModelSingle.Role == ClinicRole.Doctor)
                {
                    filtered.Add(userModelSingle);
                }
            }

            return filtered;
        }

        public List<string> DoctorListComboBox()
        {
            var userModelData = this.DoctorList();
            var mapped = new List<string>();

            foreach (var userModelSingle in userModelData)
            {
                mapped.Add(userModelSingle.Name + " " + userModelSingle.LastName);
            }

            return mapped;
        }
    }
}