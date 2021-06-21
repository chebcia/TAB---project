using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TAB_clinic_Model
{
    public static class PatientMangager
    {
        public static PatientModel? FindPatient(WrappedContext db, string pesel)
        {
            var patient = db.Context.Patients
                .Where(p => p.Pesel == pesel)
                .FirstOrDefault();

            if (patient is null)
            {
                return null;
            }

            return new PatientModel(patient);
        }
        
        public static PatientModel? FindPatientById(WrappedContext db, int patientId)
        {
            var patient = db.Context.Patients
                .Where(p => p.IdPatient == patientId)
                .FirstOrDefault();

            if (patient is null)
            {
                return null;
            }

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

            var newPatient = new PatientModel(db)
            {
                Name = name,
                LastName = lastname,
                Pesel = pesel
            };

            context.SaveChanges();
        }


        public static void UpdatePatient(WrappedContext db, int patientId, string name, string lastname, string pesel)
        {
            var selectedPatient = FindPatientById(db, patientId);
            
            if (selectedPatient == null)
            {
                Trace.WriteLine($"Patient with pesel '{pesel}' not exists");
                throw new UserAlreadyExistsException(pesel);
            }
            
            var context = db.Context;

            selectedPatient.Name = name;
            selectedPatient.LastName = lastname;
            selectedPatient.Pesel = pesel;
            context.SaveChanges();
        }
        
        public static List<PatientModel> GetPatients(WrappedContext db)
        {
            var patients = db.Context.Patients.ToList();
            var patientList = new List<PatientModel>();

            foreach (var patient in patients)
            {
                patientList.Add(new PatientModel(patient));
            }

            return patientList;
        }
    }
}