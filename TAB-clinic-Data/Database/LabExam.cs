using System;

#nullable disable

namespace TAB_clinic_Data.Database
{
    public partial class LabExam
    {
        public int IdLabExam { get; set; }
        public string DoctorsNotes { get; set; }
        public int IdVisit { get; set; }
        public int? IdWorker { get; set; }
        public int? IdManager { get; set; }
        public string Code { get; set; }
        public DateTime DtRequest { get; set; }
        public string Result { get; set; }
        public DateTime? DtFinalizedCancelled { get; set; }
        public string ManagersNotes { get; set; }
        public DateTime? DtApprovedCancelled { get; set; }
        public string Status { get; set; }

        public virtual ExamType CodeNavigation { get; set; }
        public virtual LabManager IdManagerNavigation { get; set; }
        public virtual Visit IdVisitNavigation { get; set; }
        public virtual LabWorker IdWorkerNavigation { get; set; }
    }
}
