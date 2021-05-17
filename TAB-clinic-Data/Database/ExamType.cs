using System.Collections.Generic;

#nullable disable

namespace TAB_clinic_Data.Database
{
    public partial class ExamType
    {
        public ExamType()
        {
            LabExams = new HashSet<LabExam>();
            PhysicalExams = new HashSet<PhysicalExam>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public virtual ICollection<LabExam> LabExams { get; set; }
        public virtual ICollection<PhysicalExam> PhysicalExams { get; set; }
    }
}
