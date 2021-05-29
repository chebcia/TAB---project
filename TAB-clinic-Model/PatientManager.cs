using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TAB_clinic_Data.Database;

namespace TAB_clinic_Model
{
    /// <summary>
    /// Deals with finding, creating, and fetching users.
    /// </summary>
    public static class PatientManager
    {
        public static PatientModel? FindPatient(WrappedContext db, string pesel)
        {
            var patient = db.Context.Patients
                    .Where(u => u.PESEL == pesel)
                    .FirstOrDefault();

            if (patient is null)
                return null;

            return new PatientModel(patient);
        }

        public static void CreatePatient(WrappedContext db, string name, string lastname, string pesel)
        {
            if (FindPatient(db, pesel) != null)
            {
                Trace.WriteLine($"Patient with pesel '{pesel}' already exists");
                throw new UserAlreadyExistsException(pesel);
            }

            var context = db.Context;

            var newUser = new PatientModel(db)
            {
                Name = name,
                Lastname = lastname,
                PESEL = pesel
            };
            
            context.SaveChanges();
        }

        public static List<PatientModel> GetUsers(WrappedContext db)
        {
            var users = db.Context.Patients.ToList();
            var patientList = new List<PatientModel>();
            foreach (var u in users)
            {
                patientList.Add(new PatientModel(u));
            }
            return patientList;
        }
    }
}
