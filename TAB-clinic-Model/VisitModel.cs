using System;
using System.Collections.Generic;
using TAB_clinic_Data.Database;
using static TAB_clinic_Model.VisitStatusMethods;

namespace TAB_clinic_Model
{
    public class VisitModel
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="db"></param>
        internal VisitModel(WrappedContext db)
        {
            dbVisit = new();
            db.Context.Add(dbVisit);
        }

        /// <summary>
        /// Creates a new visit based on a 
        /// </summary>
        /// <param name="visit"></param>
        internal VisitModel(Visit visit)
        {
            dbVisit = visit;
        }


        private readonly Visit dbVisit;


        public int IdVisit
        {
            get => dbVisit.IdVisit;
            set => dbVisit.IdVisit = value;
        }

        public int IdDoctor
        {
            get => dbVisit.IdDoctor;
            set => dbVisit.IdDoctor = value;
        }

        public int IdPatient
        {
            get => dbVisit.IdPatient;
            set => dbVisit.IdPatient = value;
        }

        public int IdRegistrar
        {
            get => dbVisit.IdRegistrar;
            set => dbVisit.IdRegistrar = value;
        }

        public VisitStatus Status
        {
            get => StrToStatus(dbVisit.Status);
            set => dbVisit.Status = StatusToStr(value);
        }

        public string Diagnosis
        {
            get => dbVisit.Diagnosis;
            set => dbVisit.Diagnosis = value;
        }

        public string Description
        {
            get => dbVisit.Description;
            set => dbVisit.Description = value;
        }


        public DateTime DateTimeRegistered
        {
            get => dbVisit.DtRegistered;
            set => dbVisit.DtRegistered = value;
        }

        public DateTime? DateTimeFinalizedCancelled
        {
            get => dbVisit.DtFinalizedCancelled;
            set => dbVisit.DtFinalizedCancelled = value;
        }


        public Doctor DoctorNavigation
        {
            get => dbVisit.IdDoctorNavigation;
            set => dbVisit.IdDoctorNavigation = value;
        }

        public Registrar RegistrarNavigation
        {
            get => dbVisit.IdRegistrarNavigation;
            set => dbVisit.IdRegistrarNavigation = value;
        }

        public Patient PatientNavigation
        {
            get => dbVisit.IdPatientNavigation;
            set => dbVisit.IdPatientNavigation = value;
        }

        public ICollection<LabExam> LabExams
        {
            get => dbVisit.LabExams;
            set => dbVisit.LabExams = value;
        }

        public ICollection<PhysicalExam> PhysicalExams
        {
            get => dbVisit.PhysicalExams;
            set => dbVisit.PhysicalExams = value;
        }
    }
}
