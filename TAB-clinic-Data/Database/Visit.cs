using System;
using System.Collections.Generic;

#nullable disable

namespace TAB_clinic_Data.Database
{
    public partial class Visit
    {
        public Visit()
        {
            LabExams = new HashSet<LabExam>();
            PhysicalExams = new HashSet<PhysicalExam>();
        }

        public int IdVisit { get; set; }
        public int IdDoctor { get; set; }
        public int IdPatient { get; set; }
        public int IdRegistrar { get; set; }
        public string Status { get; set; }
        public string Diagnosis { get; set; }
        public DateTime DtRegistered { get; set; }
        public DateTime? DtFinalizedCancelled { get; set; }
        public string Description { get; set; }

        public virtual Doctor IdDoctorNavigation { get; set; }
        public virtual Patient IdPatientNavigation { get; set; }
        public virtual Registrar IdRegistrarNavigation { get; set; }
        public virtual ICollection<LabExam> LabExams { get; set; }
        public virtual ICollection<PhysicalExam> PhysicalExams { get; set; }
    }
}
