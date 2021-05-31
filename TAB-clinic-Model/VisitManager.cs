using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TAB_clinic_Data.Database;

namespace TAB_clinic_Model
{
    public static class VisitManager
    {
        /// <summary>
        /// Returns the doctor's visit, filtering them with 
        /// </summary>
        /// <param name="db"></param>
        /// <param name="doctor"></param>
        /// <param name="surnameFilter">filter for the user's name, doesn't filter</param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static List<VisitModel> GetDoctorsVisits(WrappedContext db, Doctor doctor, string surnameFilter,
            DateTime? date)
        {
            System.Linq.IQueryable<Visit> visits;
            // lazy loading
            db.Context.Entry(doctor).Collection(u => u.Visits).Load();
            foreach (Visit v in doctor.Visits.ToList())
            {
                db.Context.Entry(v).Reference(r => r.IdPatientNavigation).Load();
            }

            if (date.HasValue)
            {
                visits = from v in doctor.Visits.AsQueryable()
                    where date.Value.Date.Equals(v.DtRegistered.Date) &&
                          v.IdPatientNavigation.Lastname.StartsWith(surnameFilter)
                    select v;
            }
            else
            {
                visits = from v in doctor.Visits.AsQueryable()
                    where v.IdPatientNavigation.Lastname.StartsWith(surnameFilter)
                    select v;
            }

            List<VisitModel> ret = new();
            foreach (Visit v in visits.ToList())
                ret.Add(new VisitModel(v));

            return ret;
        }

        public static VisitModel GetVisit(WrappedContext db, int id)
        {
            var visit = db.Context.Visits.Find(id);
            return new VisitModel(visit);
        }

        public static List<VisitModel> GetVisitsList(WrappedContext db)
        {
            var visits = db.Context.Visits.ToList();
            var visitsList = new List<VisitModel>();

            foreach (var visit in visits)
            {
                visitsList.Add(new VisitModel(visit));
            }
            
            return visitsList;
        }

        public static VisitModel? FindVisit(WrappedContext db, int idVisit)
        {
            var visit = db.Context.Visits
                .Where(v => v.IdVisit == idVisit)
                .FirstOrDefault();

            if (visit is null)
            {
                return null;
            }

            return new VisitModel(visit);
        }

        public static void CreateVisit(
            WrappedContext db,
            int idDoctor,
            int idPatient,
            int idRegistrar,
            VisitStatus status,
            string diagnosis,
            DateTime dtRegistered,
            DateTime? dtFinalizedCancelled,
            string? description
        )
        {
            var context = db.Context;

            var newVisit = new VisitModel(db)
            {
                IdDoctor = idDoctor,
                IdPatient = idPatient,
                IdRegistrar = idRegistrar,
                Status = status,
                Diagnosis = diagnosis,
                DateTimeRegistered = dtRegistered,
                DateTimeFinalizedCancelled = dtFinalizedCancelled,
                Description = description
            };

            context.SaveChanges();
        }

        public static void CancelVisit(WrappedContext db, int idVisit)
        {
            var selectedVisit = FindVisit(db, idVisit);

            if (selectedVisit == null)
            {
                Trace.WriteLine($"Visit with idVisit '{idVisit.ToString()}' not exists");
                throw new UserAlreadyExistsException(idVisit.ToString());
            }

            var context = db.Context;
            selectedVisit.Status = VisitStatus.cancelled;

            context.SaveChanges();
        }
    }
}