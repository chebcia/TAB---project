﻿using System;
using System.Linq;
using TAB_clinic_Data.Database;
using static TAB_clinic_Model.LabExamStatusMethods;

namespace TAB_clinic_Model
{
    public class LabExamModel
    {
        private readonly LabExam dbLabExam;

        /// <summary>
        /// Creates a new lab exam and adds it to the context. Call SaveChanges() to generate the ID.
        /// </summary>
        /// <param name="db"></param>
        internal LabExamModel(WrappedContext db) //(LabExam dbLabExam)
        {
            this.dbLabExam = new();
            this.Status = LabExamStatus.Requested; // TODO: This should be moved to the database as the default field value.
            this.DtRequest = DateTime.Now; // TODO: Maybe this should be autogenerated
            db.Context.Add(this.dbLabExam);
        }

        /// <summary>
        /// Wraps an existing bare "LabExam" object.
        /// </summary>
        /// <param name="dbUser"></param>
        internal LabExamModel(LabExam labExam)
        {
            this.dbLabExam = labExam;
        }

        

        public int IdExam
        {
            get => dbLabExam.IdLabExam;
        }

        public string DoctorsNotes
        {
            get => dbLabExam.DoctorsNotes;
            set => dbLabExam.DoctorsNotes = value;
        }

        public int IdVisit
        {
            get => dbLabExam.IdVisit;
            set => dbLabExam.IdVisit = value;
        }

        public int? IdWorker
        {
            get => dbLabExam.IdWorker;
            set => dbLabExam.IdWorker = value;
        }

        public int? IdManager
        {
            get => dbLabExam.IdManager;
            set => dbLabExam.IdManager = value;
        }

        // TODO: Make this return an ExamType value?
        // Yes, do that
        public string Code
        {
            get => dbLabExam.Code;
            set => dbLabExam.Code = value;
        }

        public string ManagersNotes
        {
            get => dbLabExam.ManagersNotes;
            set => dbLabExam.ManagersNotes = value;
        }

        public DateTime DtRequest
        {
            get => dbLabExam.DtRequest;
            set => dbLabExam.DtRequest = value;
        }

        public DateTime? DtFinalizedCancelled
        {
            get => dbLabExam.DtFinalizedCancelled;
            set => dbLabExam.DtFinalizedCancelled = value;
        }

        public DateTime? DtApprovedCancelled
        {
            get => dbLabExam.DtApprovedCancelled;
            set => dbLabExam.DtApprovedCancelled = value;
        }

        public string Result
        {
            get => dbLabExam.Result;
            set => dbLabExam.Result = value;
        }

        // TODO: dt_finalized_cancelled, managers_notes, dt_approved_cancelled

        public LabExamStatus Status
        {
            get => StringToStatus(dbLabExam.Status);
            set => dbLabExam.Status = value.StatusToDBString();
        }

        public static LabExamModel? FindLabExam(WrappedContext db, int id)
        {
            return db.Context.LabExams
                             .Where(le => le.IdLabExam == id)
                             .Select(le => new LabExamModel(le))
                             .FirstOrDefault();
        }
    }
}
